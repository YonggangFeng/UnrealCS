using System;
namespace UnrealEngine
{
	public partial class UBlueprint:UBlueprintCore
	{
		/// <summary>Whether or not this blueprint should recompile itself on load</summary>
		public bool bRecompileOnLoad;
		
		/// <summary>
		/// Pointer to the parent class that the generated class should derive from. This *can* be null under rare circumstances,
		/// one such case can be created by creating a blueprint (A) based on another blueprint (B), shutting down the editor, and
		/// deleting the parent blueprint.
		/// </summary>
		public TSubclassOf<UObject>  ParentClass;
		
		public UObject PRIVATE_InnermostPreviousCDO;
		
		/// <summary>When the class generated by this blueprint is loaded, it will be recompiled the first time.  After that initial recompile, subsequent loads will skip the regeneration step</summary>
		public bool bHasBeenRegenerated;
		
		/// <summary>State flag to indicate whether or not the Blueprint is currently being regenerated on load</summary>
		public bool bIsRegeneratingOnLoad;
		
		/// <summary>Whether or not this blueprint is newly created, and hasn't been opened in an editor yet</summary>
		public bool bIsNewlyCreated;
		
		/// <summary>Whether to force opening the full (non data-only) editor for this blueprint.</summary>
		public bool bForceFullEditor;
		
		/// <summary>whether or not you want to continuously rerun the construction script for an actor as you drag it in the editor, or only when the drag operation is complete</summary>
		public bool bRunConstructionScriptOnDrag;
		
		/// <summary>Whether or not this blueprint's class is a const class or not.  Should set CLASS_Const in the KismetCompiler.</summary>
		public bool bGenerateConstClass;
		
		/// <summary>Whether or not this blueprint's class is a abstract class or not.  Should set CLASS_Abstract in the KismetCompiler.</summary>
		public bool bGenerateAbstractClass;
		
		/// <summary>shows up in the content browser when the blueprint is hovered</summary>
		public FString BlueprintDescription;
		
		/// <summary>The category of the Blueprint, used to organize this Blueprint class when displayed in palette windows</summary>
		public FString BlueprintCategory;
		
		/// <summary>TRUE to show a warning when attempting to start in PIE and there is a compiler error on this Blueprint</summary>
		public bool bDisplayCompilePIEWarning;
		
		/// <summary>Guid key for finding searchable data for Blueprint in the DDC</summary>
		public FGuid SearchGuid;
		
		/// <summary>Deprecates the Blueprint, marking the generated class with the CLASS_Deprecated flag</summary>
		public bool bDeprecate;
		
		/// <summary>'Simple' construction script - graph of components to instance</summary>
		public USimpleConstructionScript SimpleConstructionScript;
		
		/// <summary>
		/// Flag indicating that a read only duplicate of this blueprint is being created, used to disable logic in ::PostDuplicate,
		/// This flag needs to be copied on duplication (because it's the duplicated object that we're disabling on PostDuplicate),
		/// but we don't *need* to serialize it for permanent objects.
		/// Without setting this flag a blueprint will be marked dirty when it is duplicated and if saved while in this dirty
		/// state you will not be able to open the blueprint. More specifically, UClass::Rename (called by DestroyGeneratedClass)
		/// sets a dirty flag on the package. Once saved the package will fail to open because some unnamed objects are present in
		/// the pacakge.
		/// This flag can be used to avoid the package being marked as dirty in the first place. Ideally PostDuplicateObject
		/// would not rename classes that are still in use by the original object.
		/// </summary>
		public bool bDuplicatingReadOnly;
		
		/// <summary>Stores data to override (in children classes) components (created by SCS) from parent classes</summary>
		public UInheritableComponentHandler InheritableComponentHandler;
		
		/// <summary>The type of this blueprint</summary>
		public EBlueprintType BlueprintType;
		
		/// <summary>The current status of this blueprint</summary>
		public EBlueprintStatus Status;
		
		/// <summary>The version of the blueprint system that was used to  create this blueprint</summary>
		public int BlueprintSystemVersion;
		
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo;
		
		/// <summary>The blueprint is currently compiled</summary>
		public bool bBeingCompiled;
		
		/// <summary>CRC for CDO calculated right after the latest compilation used by Reinstancer to check if default values were changed</summary>
		public uint CrcLastCompiledCDO;
		
		public uint CrcLastCompiledSignature;
		
		/// <summary>If this BP is just a duplicate created for a specific compilation, the reference to original GeneratedClass is needed</summary>
		public UClass OriginalClass;
		
		/// <summary>Deprecated properties.</summary>
		public bool bNativize;
		
		
	}
	
}
