require 'minitest/autorun'
require_relative 'go'

class GoTest < MiniTest::Unit::TestCase
  def test_go_raise_if_block_is_not_given
    assert_raises(Go::MissingBlockError) { go }
  end

  def test_go_executes_block
    a = nil

    routine = go { a = 'hola' }

    assert_equal 'hola', routine.join.value
  end

  def test_go_executes_block_in_a_thread
    assert_instance_of Thread, go {}
  end
end
