package md5a2a493f3b9411d744fae815837d465d0;


public class SignInCls
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Social_Media.SignInCls, Social Media, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SignInCls.class, __md_methods);
	}


	public SignInCls () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SignInCls.class)
			mono.android.TypeManager.Activate ("Social_Media.SignInCls, Social Media, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
