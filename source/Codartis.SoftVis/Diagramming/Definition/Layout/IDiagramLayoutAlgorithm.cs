﻿using JetBrains.Annotations;

namespace Codartis.SoftVis.Diagramming.Definition.Layout
{
    /// <summary>
    /// Calculates node positions and connector routes for a whole diagram.
    /// </summary>
    public interface IDiagramLayoutAlgorithm
    {
        [Pure]
        DiagramLayoutInfo Calculate([NotNull] IDiagram diagram);
    }
}