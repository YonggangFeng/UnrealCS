#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FPredictProjectilePathParams
	{
		[FieldOffset(0)]
		public FVector StartLocation;
		[FieldOffset(12)]
		public FVector LaunchVelocity;
		public bool bTraceWithCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(28)]
		public float ProjectileRadius;
		[FieldOffset(32)]
		public float MaxSimTime;
		public bool bTraceWithChannel
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 36, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 36, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(37)]
		public ECollisionChannel TraceChannel;
		public TStructArray<EObjectTypeQuery> ObjectTypes
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<EObjectTypeQuery>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		public TObjectArray<AActor> ActorsToIgnore
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+56, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+56, false);}}}
			
		}
		[FieldOffset(72)]
		public float SimFrequency;
		[FieldOffset(76)]
		public float OverrideGravityZ;
		[FieldOffset(80)]
		public EDrawDebugTrace DrawDebugType;
		[FieldOffset(84)]
		public float DrawDebugTime;
		public bool bTraceComplex
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 88, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 88, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
