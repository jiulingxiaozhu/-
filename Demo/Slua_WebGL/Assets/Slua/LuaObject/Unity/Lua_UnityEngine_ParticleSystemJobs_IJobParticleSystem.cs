﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemJobs_IJobParticleSystem : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Execute(IntPtr l) {
		try {
			UnityEngine.ParticleSystemJobs.IJobParticleSystem self=(UnityEngine.ParticleSystemJobs.IJobParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystemJobs.ParticleSystemJobData a1;
			checkValueType(l,2,out a1);
			self.Execute(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystemJobs.IJobParticleSystem");
		addMember(l,Execute);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleSystemJobs.IJobParticleSystem));
	}
}
