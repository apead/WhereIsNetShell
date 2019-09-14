package md519aec9d83a4d55f99ce4b5290570ae06;


public class Data_AndroidRemoteOperationListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.microsoft.appcenter.data.models.RemoteOperationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRemoteOperationCompleted:(Ljava/lang/String;Lcom/microsoft/appcenter/data/models/DocumentMetadata;Lcom/microsoft/appcenter/data/exception/DataException;)V:GetOnRemoteOperationCompleted_Ljava_lang_String_Lcom_microsoft_appcenter_data_models_DocumentMetadata_Lcom_microsoft_appcenter_data_exception_DataException_Handler:Com.Microsoft.Appcenter.Data.Models.IRemoteOperationListenerInvoker, Microsoft.AppCenter.Data.Android.Bindings\n" +
			"";
		mono.android.Runtime.register ("Microsoft.AppCenter.Data.Data+AndroidRemoteOperationListener, Microsoft.AppCenter.Data", Data_AndroidRemoteOperationListener.class, __md_methods);
	}


	public Data_AndroidRemoteOperationListener ()
	{
		super ();
		if (getClass () == Data_AndroidRemoteOperationListener.class)
			mono.android.TypeManager.Activate ("Microsoft.AppCenter.Data.Data+AndroidRemoteOperationListener, Microsoft.AppCenter.Data", "", this, new java.lang.Object[] {  });
	}


	public void onRemoteOperationCompleted (java.lang.String p0, com.microsoft.appcenter.data.models.DocumentMetadata p1, com.microsoft.appcenter.data.exception.DataException p2)
	{
		n_onRemoteOperationCompleted (p0, p1, p2);
	}

	private native void n_onRemoteOperationCompleted (java.lang.String p0, com.microsoft.appcenter.data.models.DocumentMetadata p1, com.microsoft.appcenter.data.exception.DataException p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
