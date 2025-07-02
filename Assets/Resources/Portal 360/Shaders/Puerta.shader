Shader "Portal/Puerta"
{
   
    SubShader
    {
        
        Zwrite on
        ColorMask 0
        Cull Front
   
        Stencil 
        {
         Ref 1
         Pass replace
        }

        Pass
        {
        }
    }
}
