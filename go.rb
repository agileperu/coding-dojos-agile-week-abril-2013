module Go
  class MissingBlockError < Exception; end

  class Routine
    def self.go &block
      raise MissingBlockError unless block_given?
      Thread.new { yield }
    end
  end
end
