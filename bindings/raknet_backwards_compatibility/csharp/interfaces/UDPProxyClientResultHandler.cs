/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class UDPProxyClientResultHandler : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UDPProxyClientResultHandler(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UDPProxyClientResultHandler obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UDPProxyClientResultHandler() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_UDPProxyClientResultHandler(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public UDPProxyClientResultHandler() : this(RakNetPINVOKE.new_UDPProxyClientResultHandler(), true) {
    SwigDirectorConnect();
  }

  public virtual void OnForwardingSuccess(string proxyIPAddress, ushort proxyPort, SystemAddress proxyCoordinator, SystemAddress sourceAddress, SystemAddress targetAddress, RakNetGUID targetGuid, UDPProxyClient proxyClientPlugin) {
    RakNetPINVOKE.UDPProxyClientResultHandler_OnForwardingSuccess(swigCPtr, proxyIPAddress, proxyPort, SystemAddress.getCPtr(proxyCoordinator), SystemAddress.getCPtr(sourceAddress), SystemAddress.getCPtr(targetAddress), RakNetGUID.getCPtr(targetGuid), UDPProxyClient.getCPtr(proxyClientPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnForwardingNotification(string proxyIPAddress, ushort proxyPort, SystemAddress proxyCoordinator, SystemAddress sourceAddress, SystemAddress targetAddress, RakNetGUID targetGuid, UDPProxyClient proxyClientPlugin) {
    RakNetPINVOKE.UDPProxyClientResultHandler_OnForwardingNotification(swigCPtr, proxyIPAddress, proxyPort, SystemAddress.getCPtr(proxyCoordinator), SystemAddress.getCPtr(sourceAddress), SystemAddress.getCPtr(targetAddress), RakNetGUID.getCPtr(targetGuid), UDPProxyClient.getCPtr(proxyClientPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnNoServersOnline(SystemAddress proxyCoordinator, SystemAddress sourceAddress, SystemAddress targetAddress, RakNetGUID targetGuid, UDPProxyClient proxyClientPlugin) {
    RakNetPINVOKE.UDPProxyClientResultHandler_OnNoServersOnline(swigCPtr, SystemAddress.getCPtr(proxyCoordinator), SystemAddress.getCPtr(sourceAddress), SystemAddress.getCPtr(targetAddress), RakNetGUID.getCPtr(targetGuid), UDPProxyClient.getCPtr(proxyClientPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnRecipientNotConnected(SystemAddress proxyCoordinator, SystemAddress sourceAddress, SystemAddress targetAddress, RakNetGUID targetGuid, UDPProxyClient proxyClientPlugin) {
    RakNetPINVOKE.UDPProxyClientResultHandler_OnRecipientNotConnected(swigCPtr, SystemAddress.getCPtr(proxyCoordinator), SystemAddress.getCPtr(sourceAddress), SystemAddress.getCPtr(targetAddress), RakNetGUID.getCPtr(targetGuid), UDPProxyClient.getCPtr(proxyClientPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnAllServersBusy(SystemAddress proxyCoordinator, SystemAddress sourceAddress, SystemAddress targetAddress, RakNetGUID targetGuid, UDPProxyClient proxyClientPlugin) {
    RakNetPINVOKE.UDPProxyClientResultHandler_OnAllServersBusy(swigCPtr, SystemAddress.getCPtr(proxyCoordinator), SystemAddress.getCPtr(sourceAddress), SystemAddress.getCPtr(targetAddress), RakNetGUID.getCPtr(targetGuid), UDPProxyClient.getCPtr(proxyClientPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnForwardingInProgress(string proxyIPAddress, ushort proxyPort, SystemAddress proxyCoordinator, SystemAddress sourceAddress, SystemAddress targetAddress, RakNetGUID targetGuid, UDPProxyClient proxyClientPlugin) {
    RakNetPINVOKE.UDPProxyClientResultHandler_OnForwardingInProgress(swigCPtr, proxyIPAddress, proxyPort, SystemAddress.getCPtr(proxyCoordinator), SystemAddress.getCPtr(sourceAddress), SystemAddress.getCPtr(targetAddress), RakNetGUID.getCPtr(targetGuid), UDPProxyClient.getCPtr(proxyClientPlugin));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnForwardingSuccess", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateUDPProxyClientResultHandler_0(SwigDirectorOnForwardingSuccess);
    if (SwigDerivedClassHasMethod("OnForwardingNotification", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateUDPProxyClientResultHandler_1(SwigDirectorOnForwardingNotification);
    if (SwigDerivedClassHasMethod("OnNoServersOnline", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateUDPProxyClientResultHandler_2(SwigDirectorOnNoServersOnline);
    if (SwigDerivedClassHasMethod("OnRecipientNotConnected", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateUDPProxyClientResultHandler_3(SwigDirectorOnRecipientNotConnected);
    if (SwigDerivedClassHasMethod("OnAllServersBusy", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateUDPProxyClientResultHandler_4(SwigDirectorOnAllServersBusy);
    if (SwigDerivedClassHasMethod("OnForwardingInProgress", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateUDPProxyClientResultHandler_5(SwigDirectorOnForwardingInProgress);
    RakNetPINVOKE.UDPProxyClientResultHandler_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(UDPProxyClientResultHandler));
    return hasDerivedMethod;
  }

  private void SwigDirectorOnForwardingSuccess(string proxyIPAddress, ushort proxyPort, IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin) {
    OnForwardingSuccess(proxyIPAddress, proxyPort, new SystemAddress(proxyCoordinator, false), new SystemAddress(sourceAddress, false), new SystemAddress(targetAddress, false), new RakNetGUID(targetGuid, false), (proxyClientPlugin == IntPtr.Zero) ? null : new UDPProxyClient(proxyClientPlugin, false));
  }

  private void SwigDirectorOnForwardingNotification(string proxyIPAddress, ushort proxyPort, IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin) {
    OnForwardingNotification(proxyIPAddress, proxyPort, new SystemAddress(proxyCoordinator, false), new SystemAddress(sourceAddress, false), new SystemAddress(targetAddress, false), new RakNetGUID(targetGuid, false), (proxyClientPlugin == IntPtr.Zero) ? null : new UDPProxyClient(proxyClientPlugin, false));
  }

  private void SwigDirectorOnNoServersOnline(IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin) {
    OnNoServersOnline(new SystemAddress(proxyCoordinator, false), new SystemAddress(sourceAddress, false), new SystemAddress(targetAddress, false), new RakNetGUID(targetGuid, false), (proxyClientPlugin == IntPtr.Zero) ? null : new UDPProxyClient(proxyClientPlugin, false));
  }

  private void SwigDirectorOnRecipientNotConnected(IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin) {
    OnRecipientNotConnected(new SystemAddress(proxyCoordinator, false), new SystemAddress(sourceAddress, false), new SystemAddress(targetAddress, false), new RakNetGUID(targetGuid, false), (proxyClientPlugin == IntPtr.Zero) ? null : new UDPProxyClient(proxyClientPlugin, false));
  }

  private void SwigDirectorOnAllServersBusy(IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin) {
    OnAllServersBusy(new SystemAddress(proxyCoordinator, false), new SystemAddress(sourceAddress, false), new SystemAddress(targetAddress, false), new RakNetGUID(targetGuid, false), (proxyClientPlugin == IntPtr.Zero) ? null : new UDPProxyClient(proxyClientPlugin, false));
  }

  private void SwigDirectorOnForwardingInProgress(string proxyIPAddress, ushort proxyPort, IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin) {
    OnForwardingInProgress(proxyIPAddress, proxyPort, new SystemAddress(proxyCoordinator, false), new SystemAddress(sourceAddress, false), new SystemAddress(targetAddress, false), new RakNetGUID(targetGuid, false), (proxyClientPlugin == IntPtr.Zero) ? null : new UDPProxyClient(proxyClientPlugin, false));
  }

  public delegate void SwigDelegateUDPProxyClientResultHandler_0(string proxyIPAddress, ushort proxyPort, IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin);
  public delegate void SwigDelegateUDPProxyClientResultHandler_1(string proxyIPAddress, ushort proxyPort, IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin);
  public delegate void SwigDelegateUDPProxyClientResultHandler_2(IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin);
  public delegate void SwigDelegateUDPProxyClientResultHandler_3(IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin);
  public delegate void SwigDelegateUDPProxyClientResultHandler_4(IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin);
  public delegate void SwigDelegateUDPProxyClientResultHandler_5(string proxyIPAddress, ushort proxyPort, IntPtr proxyCoordinator, IntPtr sourceAddress, IntPtr targetAddress, IntPtr targetGuid, IntPtr proxyClientPlugin);

  private SwigDelegateUDPProxyClientResultHandler_0 swigDelegate0;
  private SwigDelegateUDPProxyClientResultHandler_1 swigDelegate1;
  private SwigDelegateUDPProxyClientResultHandler_2 swigDelegate2;
  private SwigDelegateUDPProxyClientResultHandler_3 swigDelegate3;
  private SwigDelegateUDPProxyClientResultHandler_4 swigDelegate4;
  private SwigDelegateUDPProxyClientResultHandler_5 swigDelegate5;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(string), typeof(ushort), typeof(SystemAddress), typeof(SystemAddress), typeof(SystemAddress), typeof(RakNetGUID), typeof(UDPProxyClient) };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(string), typeof(ushort), typeof(SystemAddress), typeof(SystemAddress), typeof(SystemAddress), typeof(RakNetGUID), typeof(UDPProxyClient) };
  private static Type[] swigMethodTypes2 = new Type[] { typeof(SystemAddress), typeof(SystemAddress), typeof(SystemAddress), typeof(RakNetGUID), typeof(UDPProxyClient) };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(SystemAddress), typeof(SystemAddress), typeof(SystemAddress), typeof(RakNetGUID), typeof(UDPProxyClient) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(SystemAddress), typeof(SystemAddress), typeof(SystemAddress), typeof(RakNetGUID), typeof(UDPProxyClient) };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(string), typeof(ushort), typeof(SystemAddress), typeof(SystemAddress), typeof(SystemAddress), typeof(RakNetGUID), typeof(UDPProxyClient) };
}

}
