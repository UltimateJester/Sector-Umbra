using Content.Server.NPC.Queries.Curves;
using JetBrains.Annotations;

namespace Content.Server.NPC.Queries.Considerations;

[ImplicitDataDefinitionForInheritors, MeansImplicitUse]
public abstract class UtilityConsideration
{
    [DataField("curve", required: true)]
    public IUtilityCurve Curve = default!;
}
