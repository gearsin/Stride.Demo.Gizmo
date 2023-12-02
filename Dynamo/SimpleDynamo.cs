using Stride.Assets.Presentation.AssetEditors.Gizmos;
using Stride.Core.Mathematics;
using Stride.Engine;
using Stride.Extensions;
using Stride.Graphics;
using Stride.Graphics.GeometricPrimitives;
using Stride.Rendering;
using Stride.Rendering.Sprites;

namespace Dynamo
{

    [GizmoComponent(typeof(TransformComponent), false)]
    public class SimpleDynamo : EntityGizmo<TransformComponent>
    {

        private const string GizmoName = "DummyGizmo";
        public SimpleDynamo(EntityComponent component) : base(component)
        {
        }


        protected override Entity Create()
        {
            //var gizmoTexture = GraphicsDevice.GetOrCreateSharedData(GizmoName, d => TextureExtensions.FromFileData(d, Resources.DummyGizmo));

            // Create a root that will contains the billboard as a child, so that it is easier to add other elements with only the billboard set as a GizmoScalingEntity
            var root = new Entity(GizmoName);
            var cubeMeshDraw = GeometricPrimitive.Cone.New(GraphicsDevice, 0.16f).ToMeshDraw();

            var material = GizmoEmissiveColorMaterial.Create(GraphicsDevice, Color.IndianRed, 0.75f);

            var gizmo = new Entity(GizmoName + " Billboard")
                {
                new ModelComponent { Model = new Model { material, new Mesh { Draw = cubeMeshDraw } }, RenderGroup = RenderGroup }
            };

            root.AddChild(gizmo);

            // Scaling should only affect billboard
            GizmoScalingEntity = gizmo;

            return root;

        }
    }
}
