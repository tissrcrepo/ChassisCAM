using Flux.API;
using ChassisCAM.Core.Geometries;
using ChassisCAM.Core.Optimizer;

namespace ChassisCAM.Core.GCodeGen;

public struct Frame {
   public List<ToolScope<Tooling>> ToolScopes { get; set; } = [];
   public Frame () { }
}
