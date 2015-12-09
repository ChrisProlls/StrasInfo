using Mcg.System;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;



namespace __InterfaceProxies
{
	public class ServiceChannelProxy_ServiceSoap : global::System.ServiceModel.Channels.ServiceChannelProxy_P, global::StrasInfo.StrasServiceSoap.ServiceSoap_P
	{
		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret_P> global::StrasInfo.StrasServiceSoap.ServiceSoap_P.rechercherCodesArretsDepuisLibelleAsync(
					string Saisie, 
					int NoPage)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::StrasInfo.StrasServiceSoap.ServiceSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					Saisie, 
					NoPage
			};
			global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret_P> retval = ((global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb_P> global::StrasInfo.StrasServiceSoap.ServiceSoap_P.rechercheProchainesArriveesWebAsync(
					string CodeArret, 
					int Mode, 
					string Heure, 
					int NbHoraires)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::StrasInfo.StrasServiceSoap.ServiceSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					CodeArret, 
					Mode, 
					Heure, 
					NbHoraires
			};
			global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb_P> retval = ((global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageFichesHoraires_P> global::StrasInfo.StrasServiceSoap.ServiceSoap_P.rechercheFichesHorairesAsync(string CodeArret)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::StrasInfo.StrasServiceSoap.ServiceSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					CodeArret
			};
			global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageFichesHoraires_P> retval = ((global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageFichesHoraires_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageInfosTrafic_P> global::StrasInfo.StrasServiceSoap.ServiceSoap_P.infosTraficAsync()
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::StrasInfo.StrasServiceSoap.ServiceSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[0];
			global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageInfosTrafic_P> retval = ((global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageInfosTrafic_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageDeviations_P> global::StrasInfo.StrasServiceSoap.ServiceSoap_P.deviationsAsync()
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::StrasInfo.StrasServiceSoap.ServiceSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[0];
			global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageDeviations_P> retval = ((global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageDeviations_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}
	}

	[global::System.Runtime.CompilerServices.EagerStaticClassConstruction]
	[global::System.Runtime.CompilerServices.DependencyReductionRoot]
	public static class __DispatchProxyImplementationData
	{
		static global::System.Reflection.DispatchProxyEntry[] s_entryTable = new global::System.Reflection.DispatchProxyEntry[] {
				new global::System.Reflection.DispatchProxyEntry() {
					ProxyClassType = typeof(global::System.ServiceModel.Channels.ServiceChannelProxy_P).TypeHandle,
					InterfaceType = typeof(global::StrasInfo.StrasServiceSoap.ServiceSoap_P).TypeHandle,
					ImplementationClassType = typeof(global::__InterfaceProxies.ServiceChannelProxy_ServiceSoap).TypeHandle,
				}
		};
		static __DispatchProxyImplementationData()
		{
			global::System.Reflection.DispatchProxyHelpers.RegisterImplementations(s_entryTable);
		}
	}
}

namespace StrasInfo.StrasServiceSoap
{
	[global::System.Runtime.InteropServices.McgRedirectedType("StrasInfo.StrasServiceSoap.ServiceSoap, StrasInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public interface ServiceSoap_P
	{
		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret_P> rechercherCodesArretsDepuisLibelleAsync(
					string Saisie, 
					int NoPage);

		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb_P> rechercheProchainesArriveesWebAsync(
					string CodeArret, 
					int Mode, 
					string Heure, 
					int NbHoraires);

		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageFichesHoraires_P> rechercheFichesHorairesAsync(string CodeArret);

		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageInfosTrafic_P> infosTraficAsync();

		global::System.Threading.Tasks.Task_P<global::StrasInfo.StrasServiceSoap.MessageDeviations_P> deviationsAsync();
	}
}

namespace System.Reflection
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Reflection.DispatchProxy, System.Private.Interop, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
		"7f11d50a3a")]
	public class DispatchProxy_P
	{
	}
}

namespace System.ServiceModel.Channels
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.ServiceModel.Channels.ServiceChannelProxy, System.Private.ServiceModel, Version=4.0.0.0, Culture=neutral," +
		" PublicKeyToken=b03f5f7f11d50a3a")]
	public class ServiceChannelProxy_P : global::System.Reflection.DispatchProxy
	{
		protected override object Invoke(
					global::System.Reflection.MethodInfo targetMethodInfo, 
					object[] args)
		{
			return null;
		}
	}
}

namespace StrasInfo.StrasServiceSoap
{
	[global::System.Runtime.InteropServices.McgRedirectedType("StrasInfo.StrasServiceSoap.MessageRechercheCodeArret, StrasInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToke" +
		"n=null")]
	public class MessageRechercheCodeArret_P
	{
	}
}

namespace System.Threading.Tasks
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Threading.Tasks.Task`1, System.Private.Threading, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
		"7f11d50a3a")]
	public class Task_P<TResult>
	{
	}
}

namespace StrasInfo.StrasServiceSoap
{
	[global::System.Runtime.InteropServices.McgRedirectedType("StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb, StrasInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
		"null")]
	public class MessageArriveesAppliWeb_P
	{
	}
}

namespace StrasInfo.StrasServiceSoap
{
	[global::System.Runtime.InteropServices.McgRedirectedType("StrasInfo.StrasServiceSoap.MessageFichesHoraires, StrasInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
		"ll")]
	public class MessageFichesHoraires_P
	{
	}
}

namespace StrasInfo.StrasServiceSoap
{
	[global::System.Runtime.InteropServices.McgRedirectedType("StrasInfo.StrasServiceSoap.MessageInfosTrafic, StrasInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class MessageInfosTrafic_P
	{
	}
}

namespace StrasInfo.StrasServiceSoap
{
	[global::System.Runtime.InteropServices.McgRedirectedType("StrasInfo.StrasServiceSoap.MessageDeviations, StrasInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class MessageDeviations_P
	{
	}
}
