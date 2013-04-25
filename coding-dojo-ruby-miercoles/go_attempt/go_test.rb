require 'minitest/autorun'
require_relative 'go'

class GoTest < MiniTest::Unit::TestCase
  def test_go_raise_if_block_is_not_given
    assert_raises(Go::MissingBlockError) { go }
  end

  def test_go_executes_block
    a = nil

    go { a = 'hola' }
    sleep 0.1

    assert_equal 'hola', a
  end

  def test_go_executes_block_in_a_thread
    assert_instance_of Thread, go{}
  end
end

class ChannelTest < MiniTest::Unit::TestCase
  def test_new_channel_size_is_zero
    assert_equal 0, channel.size
  end

  def test_can_push_to_channel
    c = channel
    c << 1

    assert_equal 1, c.size
  end

  def test_can_consume
    c = channel
    c << 1

    assert_equal 1, c.pop
  end
end

class ProducerConsumerTest < MiniTest::Unit::TestCase
  def test_can_produce_consume
    c = channel

    producer = ->(c) { c << 5 }

    control = nil
    consumer = ->(c) { control = c.pop }

    go c, &producer
    go c, &consumer
    sleep 0.1

    assert_equal 5, control
  end
end
