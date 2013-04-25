require 'thread'

module Go
  class Channel
    def initialize
      @queue = Queue.new
    end

    def << value
      @queue.push value
    end

    def size
      @queue.size
    end
  end
end
