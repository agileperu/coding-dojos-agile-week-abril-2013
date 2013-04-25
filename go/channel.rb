require 'thread'

module Go
  class Channel
    def initialize
      @queue = Queue.new
    end

    def << value
      @queue << value
    end

    def size
      @queue.size
    end

    def pop
      @queue.pop
    end
  end
end
