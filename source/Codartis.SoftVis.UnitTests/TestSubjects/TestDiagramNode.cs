﻿using System;
using Codartis.SoftVis.Diagramming;
using Codartis.SoftVis.Diagramming.Implementation;
using Codartis.SoftVis.Geometry;
using Codartis.SoftVis.Modeling;

namespace Codartis.SoftVis.UnitTests.TestSubjects
{
    internal sealed class TestDiagramNode : DiagramNodeBase
    {
        public TestDiagramNode(string name = "dummy")
            : base(new TestModelNode(name), parentDiagramNode: null)
        {
        }

        protected override IDiagramNode CreateInstance(IModelNode modelNode, Size2D size, Point2D center, DateTime addedAt, IContainerDiagramNode parentDiagramNode)
            => new TestDiagramNode(Name);
    }
}