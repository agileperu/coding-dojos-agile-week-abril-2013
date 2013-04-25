module Go
  class MissingBlockError < Exception; end

  class Routine
    def self.go block
      Thread.new &block
    end
  end
end
