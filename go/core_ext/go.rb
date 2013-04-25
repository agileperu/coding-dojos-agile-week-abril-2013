module Kernel
  def go block
    Go::Routine.go block
  end
end
