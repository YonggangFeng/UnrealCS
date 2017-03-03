#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>ForceFeedbackComponent allows placing a rumble effect in to the world and having it apply to player characters who come near it</summary>
	public partial class UForceFeedbackComponent
	{
		static readonly int ForceFeedbackEffect__Offset;
		/// <summary>The feedback effect to be played</summary>
		public UForceFeedbackEffect ForceFeedbackEffect
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ForceFeedbackEffect__Offset); if (v == IntPtr.Zero)return null; UForceFeedbackEffect retValue = new UForceFeedbackEffect(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ForceFeedbackEffect__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ForceFeedbackEffect__Offset, value._this.Get()); }
			
		}
		
		static readonly int bAutoDestroy__Offset;
		/// <summary>Auto destroy this component on completion</summary>
		public bool bAutoDestroy
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoDestroy__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bStopWhenOwnerDestroyed__Offset;
		/// <summary>Stop effect when owner is destroyed</summary>
		public bool bStopWhenOwnerDestroyed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStopWhenOwnerDestroyed__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bLooping__Offset;
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLooping__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bOverrideAttenuation__Offset;
		/// <summary>Should the Attenuation Settings asset be used (false) or should the properties set directly on the component be used for attenuation properties</summary>
		public bool bOverrideAttenuation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideAttenuation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideAttenuation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int IntensityMultiplier__Offset;
		/// <summary>The intensity multiplier to apply to effects generated by this component</summary>
		public float IntensityMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IntensityMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IntensityMultiplier__Offset, false);}
			
		}
		
		static readonly int AttenuationSettings__Offset;
		/// <summary>If bOverrideSettings is false, the asset to use to determine attenuation properties for effects generated by this component</summary>
		public UForceFeedbackAttenuation AttenuationSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AttenuationSettings__Offset); if (v == IntPtr.Zero)return null; UForceFeedbackAttenuation retValue = new UForceFeedbackAttenuation(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, value._this.Get()); }
			
		}
		
		static readonly int AttenuationOverrides__Offset;
		/// <summary>If bOverrideSettings is true, the attenuation properties to use for effects generated by this component</summary>
		public FForceFeedbackAttenuationSettings AttenuationOverrides
		{
			get{ CheckIsValid();return (FForceFeedbackAttenuationSettings)Marshal.PtrToStructure(_this.Get()+AttenuationOverrides__Offset, typeof(FForceFeedbackAttenuationSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttenuationOverrides__Offset, false);}
			
		}
		
		static readonly int OnForceFeedbackFinished__Offset;
		/// <summary>called when we finish playing audio, either because it played to completion or because a Stop() call turned it off early</summary>
		public FMulticastScriptDelegate OnForceFeedbackFinished
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnForceFeedbackFinished__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnForceFeedbackFinished__Offset, false);}
			
		}
		
		static UForceFeedbackComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ForceFeedbackComponent");
			ForceFeedbackEffect__Offset=GetPropertyOffset(NativeClassPtr,"ForceFeedbackEffect");
			bAutoDestroy__Offset=GetPropertyOffset(NativeClassPtr,"bAutoDestroy");
			bStopWhenOwnerDestroyed__Offset=GetPropertyOffset(NativeClassPtr,"bStopWhenOwnerDestroyed");
			bLooping__Offset=GetPropertyOffset(NativeClassPtr,"bLooping");
			bOverrideAttenuation__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideAttenuation");
			IntensityMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"IntensityMultiplier");
			AttenuationSettings__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationSettings");
			AttenuationOverrides__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationOverrides");
			OnForceFeedbackFinished__Offset=GetPropertyOffset(NativeClassPtr,"OnForceFeedbackFinished");
			
		}
		
	}
	
}
#endif
#endif
