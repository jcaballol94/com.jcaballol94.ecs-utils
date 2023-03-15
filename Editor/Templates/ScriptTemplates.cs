using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace jCaballol94.ECS
{
    public static class ScriptTemplates
    {
        private const string PATH = "Packages/com.jcaballol94.ecs-utils/Editor/Templates/Data~/";

        [MenuItem("Assets/Create/ECS Scripts/Component", priority = 0)]
        public static void CreateEcsComponent()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(PATH + "ComponentTemplate.cs", "NewComponent.cs");
        }

        [MenuItem("Assets/Create/ECS Scripts/Buffer", priority = 0)]
        public static void CreateEcsBuffer()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(PATH + "BufferTemplate.cs", "NewBuffer.cs");
        }

        [MenuItem("Assets/Create/ECS Scripts/Aspect", priority = 0)]
        public static void CreateAspect()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(PATH + "AspectTemplate.cs", "NewAspect.cs");
        }

        [MenuItem("Assets/Create/ECS Scripts/Authoring", priority = 0)]
        public static void CreateAuthoring()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(PATH + "AuthoringTemplate.cs", "NewAuthoring.cs");
        }

        [MenuItem("Assets/Create/ECS Scripts/ISystem", priority = 0)]
        public static void CreateISystem()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(PATH + "ISystemTemplate.cs", "NewSystem.cs");
        }

        [MenuItem("Assets/Create/ECS Scripts/SystemGroup", priority = 0)]
        public static void CreateSystemGroup()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(PATH + "SystemGroupTemplate.cs", "NewSystemGroup.cs");
        }

        [MenuItem("Assets/Create/ECS Scripts/CommandBufferSystem", priority = 0)]
        public static void CreateCommandBufferSystem()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(PATH + "CommandBufferSystemTemplate.cs", "NewCommandBufferSystem.cs");
        }

        [MenuItem("Assets/Create/ECS Scripts/Event", priority = 0)]
        public static void CreateEvent()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(PATH + "EventTemplate.cs", "NewEvent.cs");
        }
    }
}
