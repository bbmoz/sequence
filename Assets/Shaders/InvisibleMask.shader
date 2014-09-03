Shader "Custom/InvisibleMask" {
	SubShader {
		// render after all opaque and transparent objects
		Tags { "Queue"="Transparent+1" }
		
		// keep the image behind it
		Pass { Blend Zero One }
	} 
}
