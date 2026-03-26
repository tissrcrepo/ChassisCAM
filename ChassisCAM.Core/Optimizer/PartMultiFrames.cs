using Flux.API;
using ChassisCAM.Core.Optimizer;

namespace ChassisCAM.Core.GCodeGen;


public class PartMultiFrames {
   Workpiece mWork;
   public PartMultiFrames (Workpiece work) {
      mWork = work;
   }
}