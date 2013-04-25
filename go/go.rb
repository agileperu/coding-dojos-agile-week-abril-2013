module Go
  class MissingBlockError < Exception; end

  class Routine
    def self.go *args
      raise MissingBlockError unless block_given?
      Thread.new(*args) { |*a| yield(*a) }
    end
  end
end
