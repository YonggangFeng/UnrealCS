#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FPhysicalSurfaceName
	{
		[FieldOffset(0)]
		public EPhysicalSurface Type;
		[FieldOffset(4)]
		public FName Name;
		
	}
	
}
#endif
#endif
