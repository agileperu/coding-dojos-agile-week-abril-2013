module Kernel
  def go *args, &block
    Go::Routine.go *args, &block
  end
end
