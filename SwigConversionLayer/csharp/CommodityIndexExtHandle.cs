//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace EliteQuant {

public class CommodityIndexExtHandle : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CommodityIndexExtHandle(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CommodityIndexExtHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CommodityIndexExtHandle() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CommodityIndexExtHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CommodityIndexExtHandle(CommodityIndexExt arg0) : this(NQuantLibcPINVOKE.new_CommodityIndexExtHandle__SWIG_0(CommodityIndexExt.getCPtr(arg0)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CommodityIndexExtHandle() : this(NQuantLibcPINVOKE.new_CommodityIndexExtHandle__SWIG_1(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CommodityIndexExt __deref__() {
    CommodityIndexExt ret = new CommodityIndexExt(NQuantLibcPINVOKE.CommodityIndexExtHandle___deref__(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = NQuantLibcPINVOKE.CommodityIndexExtHandle_empty(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Observable asObservable() {
    Observable ret = new Observable(NQuantLibcPINVOKE.CommodityIndexExtHandle_asObservable(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string name() {
    string ret = NQuantLibcPINVOKE.CommodityIndexExtHandle_name(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void update() {
    NQuantLibcPINVOKE.CommodityIndexExtHandle_update(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Calendar calendar() {
    Calendar ret = new Calendar(NQuantLibcPINVOKE.CommodityIndexExtHandle_calendar(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double price(Date date) {
    double ret = NQuantLibcPINVOKE.CommodityIndexExtHandle_price(swigCPtr, Date.getCPtr(date));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double forwardPrice(Date date) {
    double ret = NQuantLibcPINVOKE.CommodityIndexExtHandle_forwardPrice(swigCPtr, Date.getCPtr(date));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date lastQuoteDate() {
    Date ret = new Date(NQuantLibcPINVOKE.CommodityIndexExtHandle_lastQuoteDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addQuote(Date quoteDate, double quote) {
    NQuantLibcPINVOKE.CommodityIndexExtHandle_addQuote(swigCPtr, Date.getCPtr(quoteDate), quote);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearQuotes() {
    NQuantLibcPINVOKE.CommodityIndexExtHandle_clearQuotes(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValidQuoteDate(Date quoteDate) {
    bool ret = NQuantLibcPINVOKE.CommodityIndexExtHandle_isValidQuoteDate(swigCPtr, Date.getCPtr(quoteDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RealTimeSeries quotes() {
    RealTimeSeries ret = new RealTimeSeries(NQuantLibcPINVOKE.CommodityIndexExtHandle_quotes(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setForwardCurve(CommodityCurveExt forwardCurve) {
    NQuantLibcPINVOKE.CommodityIndexExtHandle_setForwardCurve(swigCPtr, CommodityCurveExt.getCPtr(forwardCurve));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}