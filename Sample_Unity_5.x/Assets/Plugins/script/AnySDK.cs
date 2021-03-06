using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;
using System.Text;

namespace anysdk
{

	public class AnySDK
	{
		private static AnySDK _instance;
		
		public static AnySDK getInstance() {
			if( null == _instance ) {
				_instance = new AnySDK();
			}
			return _instance;
		}

		/**
   		 @breif the init of AgentManager
   		 @param the appKey of anysdk
    	 @param the appSecret of anysdk
   		 @param the privateKey of anysdk
    	 @param the url of oauthLoginServer
   		 @warning Must invoke this interface before loadALLPlugin
  		*/

		public  void init(string appKey, string appSecret, string privateKey, string authLoginServer)
		{

#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS)
			AnySDK_nativeInitPluginSystem (appKey, appSecret, privateKey, authLoginServer);
#else
			Debug.Log("This platform does not support!");
#endif
		}


		[Obsolete("This interface is obsolete!",false)]
		public  void loadALLPlugin()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			Debug.Log("This interface is obsolete!");
#else
			Debug.Log("This platform does not support!");
#endif
		}

		/**
    	 @brief Get custom param
     	@return  return value is custom param for channel.
    	 */

		public  string getCustomParam()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			StringBuilder customParam = new StringBuilder();
			customParam.Capacity = AnySDKUtil.MAX_CAPACITY_NUM;
			AnySDK_nativeGetCustomParam (customParam);
			return customParam.ToString();
#else
			Debug.Log("This platform does not support!");
			return "";
#endif

		}

		/**
    	 @brief Get channel ID
     	@return  return value is channel ID.
     	*/
		public  string getChannelId()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			StringBuilder channelId = new StringBuilder();
			channelId.Capacity = AnySDKUtil.MAX_CAPACITY_NUM;
			AnySDK_nativeGetChannelId (channelId);
			return channelId.ToString();
#else
			Debug.Log("This platform does not support!");
			return "";
#endif

		}

		/**
    	 @brief Get framework version
     	@return  return value is framework version.
     	*/
		public  string getFrameworkVersion()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			StringBuilder version = new StringBuilder();
			version.Capacity = AnySDKUtil.MAX_CAPACITY_NUM;
			AnySDK_nativeGetFrameworkVersion (version);
			return version.ToString();
#else
			Debug.Log("This platform does not support!");
			return "";
#endif


		}

		/**
     		@brief release the anysdk
     	*/

		public  void release()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			AnySDK_nativeRelease ();
#else
			Debug.Log("This platform does not support!");
#endif

		}

		/**
		 * 
		* @Title: isUserPluginExist 
		* @Description: is UserPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isUserPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsUserPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		/**
		 * 
		* @Title: isIAPPluginExist 
		* @Description: is IAPPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isIAPPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsIAPPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		/**
		 * 
		* @Title: isAdsPluginExist 
		* @Description: is AdsPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isAdsPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsAdsPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		/**
		 * 
		* @Title: isAnalyticsPluginExist 
		* @Description: is AnalyticsPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isAnalyticsPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsAnalyticsPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		/**
		 * 
		* @Title: isPushPluginExist 
		* @Description: is PushPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isPushPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsPushPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		/**
		 * 
		* @Title: isSharePluginExist 
		* @Description: is SharePlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isSharePluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsSharePluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		/**
		 * 
		* @Title: isSocialPluginExist 
		* @Description: is SocialPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isSocialPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsSocialPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		/**
		 * 
		* @Title: isCustomPluginExist 
		* @Description: is CustomPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isCustomPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsCustomPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		/**
		 * 
		* @Title: isRECPluginExist 
		* @Description: is RECPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isRECPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsRECPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

				/**
		 * 
		* @Title: isCrashPluginExist 
		* @Description: is CrashPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isCrashPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsCrashPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

				/**
		 * 
		* @Title: isAdTrackingPluginExist 
		* @Description: is AdTrackingPlugin Exist 
		* @param @return   true or false     
		* @return boolean   
	 	*/

		public bool isAdTrackingPluginExist()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsAdTrackingPluginExist ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		/**
	 	* 
		* @Title: setIsAnaylticsEnabled 
		* @Description: choose to open or close
		* @param @param enabled    true or false  
		* @return void   
	 	*/

		public void setIsAnaylticsEnabled(bool enabled)
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			AnySDK_nativeSetIsAnaylticsEnabled (enabled);
#else
			Debug.Log("This platform does not support!");
#endif
		}

		/**
		 * 
		* @Title: isAnaylticsEnabled 
		* @Description: the status of Anayltics
		* @param @return    true or false    
		* @return boolean   
		 */

		public bool isAnaylticsEnabled()
		{
#if !UNITY_EDITOR &&( UNITY_ANDROID ||  UNITY_IOS) 
			return AnySDK_nativeIsAnaylticsEnabled ();
#else
			Debug.Log("This platform does not support!");
			return false;
#endif
		}

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern void AnySDK_nativeInitPluginSystem(string appKey, string appSecret, string privateKey, string authLoginServer);

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern void AnySDK_nativeLoadPlugins();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern void AnySDK_nativeGetChannelId(StringBuilder channelId);

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern void AnySDK_nativeGetFrameworkVersion(StringBuilder version);

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern void AnySDK_nativeGetCustomParam(StringBuilder customParam);

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern void AnySDK_nativeRelease();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsUserPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsIAPPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsAdsPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsAnalyticsPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsSharePluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsSocialPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsPushPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsAdTrackingPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsCustomPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsRECPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsCrashPluginExist();

		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern void AnySDK_nativeSetIsAnaylticsEnabled(bool enabled);
		
		[DllImport(AnySDKUtil.ANYSDK_PLATFORM)]
		private static extern bool AnySDK_nativeIsAnaylticsEnabled();

	}
}

