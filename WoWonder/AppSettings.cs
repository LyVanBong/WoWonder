//##############################################
//Cᴏᴘʏʀɪɢʜᴛ 2020 DᴏᴜɢʜᴏᴜᴢLɪɢʜᴛ Codecanyon Item 19703216
//Elin Doughouz >> https://www.facebook.com/Elindoughouz
//====================================================

//For the accuracy of the icon and logo, please use this website " https://appicon.co " and add images according to size in folders " mipmap " 

using System.Collections.Generic;
using WoWonder.Activities.NativePost.Extra;
using WoWonder.Helpers.Model;

namespace WoWonder
{
    internal static class AppSettings
    {
        /// <summary>
        /// Deep Links To App Content
        /// you should add your website without http in the analytic.xml file >> ../values/analytic.xml .. line 5
        /// <string name="ApplicationUrlWeb">demo.wowonder.com</string>
        /// </summary>
        public static string TripleDesAppServiceProvider = "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";

        //Main Settings >>>>>
        //*********************************************************
        public static string Version = "5.0";
        public static string ApplicationName = "WoWonder Timeline";
        public static string DatabaseName = "WowonderSocial"; 

        // Friend system = 0 , follow system = 1
        public static int ConnectivitySystem = 1;
         
        //Main Colors >>
        //*********************************************************
        public static string MainColor = "#a84849";
         
        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = false;
        public static string Lang = ""; //Default language ar

        //Set Language User on site from phone 
        public static bool SetLangUser = true; 

        //Notification Settings >>
        //*********************************************************
        public static bool ShowNotification = true;
        public static string OneSignalAppId = "64974c58-9993-40ed-b782-0814edc401ea";

        // WalkThrough Settings >>
        //*********************************************************
        public static bool ShowWalkTroutPage = true;

        //Main Messenger settings
        //*********************************************************
        public static bool MessengerIntegration = true;
        public static bool ShowDialogAskOpenMessenger = false; 
        public static string MessengerPackageName = "com.wowondermessenger.app"; //APK name on Google Play

        //AdMob >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static ShowAds ShowAds = ShowAds.AllUsers;

        //Three times after entering the ad is displayed
        public static int ShowAdInterstitialCount = 3;
        public static int ShowAdRewardedVideoCount = 3;
        public static int ShowAdNativeCount = 40;
        public static int ShowAdAppOpenCount = 2;
         
        public static bool ShowAdMobBanner = true;
        public static bool ShowAdMobInterstitial = true;
        public static bool ShowAdMobRewardVideo = true;
        public static bool ShowAdMobNative = true;
        public static bool ShowAdMobNativePost = true;
        public static bool ShowAdMobAppOpen = true;  
        public static bool ShowAdMobRewardedInterstitial = true;  

        public static string AdInterstitialKey = "ca-app-pub-5135691635931982/3584502890";
        public static string AdRewardVideoKey = "ca-app-pub-5135691635931982/2518408206";
        public static string AdAdMobNativeKey = "ca-app-pub-5135691635931982/2280543246";
        public static string AdAdMobAppOpenKey = "ca-app-pub-5135691635931982/2813560515";  
        public static string AdRewardedInterstitialKey = "ca-app-pub-5135691635931982/7842669101";  
         
        //FaceBook Ads >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static bool ShowFbBannerAds = false; 
        public static bool ShowFbInterstitialAds = false;  
        public static bool ShowFbRewardVideoAds = false; 
        public static bool ShowFbNativeAds = false; 
         
        //YOUR_PLACEMENT_ID
        public static string AdsFbBannerKey = "250485588986218_554026418632132"; 
        public static string AdsFbInterstitialKey = "250485588986218_554026125298828";  
        public static string AdsFbRewardVideoKey = "250485588986218_554072818627492"; 
        public static string AdsFbNativeKey = "250485588986218_554706301897477"; 
         
        //Colony Ads >> Please add the code ad in the Here 
        //*********************************************************  
        public static bool ShowColonyBannerAds = true; 
        public static bool ShowColonyInterstitialAds = true; 
        public static bool ShowColonyRewardAds = true;  

        public static string AdsColonyAppId = "appff22269a7a0a4be8aa"; 
        public static string AdsColonyBannerId = "vz85ed7ae2d631414fbd"; 
        public static string AdsColonyInterstitialId = "vz39712462b8634df4a8";  
        public static string AdsColonyRewardedId = "vz32ceec7a84aa4d719a"; 
        //********************************************************* 

        public static bool EnableRegisterSystem = true;

        /// <summary>
        /// true => Only over 18 years old
        /// false => all 
        /// </summary>
        public static bool IsUserYearsOld = true;
        public static bool AddAllInfoPorfileAfterRegister = true; //#New

        //Set Theme Full Screen App
        //*********************************************************
        public static bool EnableFullScreenApp = false;
            
        //Code Time Zone (true => Get from Internet , false => Get From #CodeTimeZone )
        //*********************************************************
        public static bool AutoCodeTimeZone = true;
        public static string CodeTimeZone = "UTC";

        //Error Report Mode
        //*********************************************************
        public static bool SetApisReportMode = false;

        //Social Logins >>
        //If you want login with facebook or google you should change id key in the analytic.xml file 
        //Facebook >> ../values/analytic.xml .. line 10-11 
        //Google >> ../values/analytic.xml .. line 15 
        //*********************************************************
        public static bool EnableSmartLockForPasswords = true; //#New

        public static bool ShowFacebookLogin = true;
        public static bool ShowGoogleLogin = true;

        public static readonly string ClientId = "430795656343-679a7fus3pfr1ani0nr0gosotgcvq2s8.apps.googleusercontent.com";

        //########################### 

        //Main Slider settings
        //*********************************************************
        public static PostButtonSystem PostButton = PostButtonSystem.ReactionDefault;
        public static ToastTheme ToastTheme = ToastTheme.Custom; 

        public static BottomNavigationSystem NavigationBottom = BottomNavigationSystem.Default; 

        public static bool ShowBottomAddOnTab = true; 
        public static bool ShowFilterPost = true; //#New

        public static bool ShowAlbum = true;
        public static bool ShowArticles = true;
        public static bool ShowPokes = true;
        public static bool ShowCommunitiesGroups = true;
        public static bool ShowCommunitiesPages = true;
        public static bool ShowMarket = true;
        public static bool ShowPopularPosts = true;
        /// <summary>
        /// if selected false will remove boost post and get list Boosted Posts
        /// </summary>
        public static bool ShowBoostedPosts = true;  
        public static bool ShowBoostedPages = true;  
        public static bool ShowMovies = true;
        public static bool ShowNearBy = true;
        public static bool ShowStory = true;
        public static bool ShowSavedPost = true;
        public static bool ShowUserContacts = true; 
        public static bool ShowJobs = true; 
        public static bool ShowCommonThings = true; 
        public static bool ShowFundings = true;
        public static bool ShowMyPhoto = true; 
        public static bool ShowMyVideo = true; 
        public static bool ShowGames = true;
        public static bool ShowMemories = true;  
        public static bool ShowOffers = true;  
        public static bool ShowNearbyShops = true;   

        public static bool ShowSuggestedPage = true; 
        public static bool ShowSuggestedGroup = true;
        public static bool ShowSuggestedUser = true;
         
        //count times after entering the Suggestion is displayed
        public static int ShowSuggestedPageCount = 90;  
        public static int ShowSuggestedGroupCount = 70; 
        public static int ShowSuggestedUserCount = 50;

        //allow download or not when share
        public static bool AllowDownloadMedia = true; 

        public static bool ShowAdvertise = true;  
         
        /// <summary>
        /// https://rapidapi.com/api-sports/api/covid-193
        /// you can get api key and host from here https://prnt.sc/wngxfc 
        /// </summary>
        public static bool ShowInfoCoronaVirus = true;  
        public static string KeyCoronaVirus = "164300ef98msh0911b69bed3814bp131c76jsneaca9364e61f"; 
        public static string HostCoronaVirus = "covid-193.p.rapidapi.com"; 
         
        public static bool ShowLive = true;
        public static string AppIdAgoraLive = "619ee4ec26334d2dae20e52d1abbb32e";

        //Events settings
        //*********************************************************  
        public static bool ShowEvents = true; 
        public static bool ShowEventGoing = true; 
        public static bool ShowEventInvited = true;  
        public static bool ShowEventInterested = true;  
        public static bool ShowEventPast = true;

        // Story >>
        //*********************************************************
        //Set a story duration >> Sec
        public static long StoryImageDuration = 7; 
        public static long StoryVideoDuration = 30; //#New

        /// <summary>
        /// If it is false, it will appear only for the specified time in the value of the StoryVideoDuration
        /// </summary>
        public static bool ShowFullVideo = false; //#New

        public static bool EnableStorySeenList = true; 
        public static bool EnableReplyStory = true;
         
        /// <summary>
        /// https://dashboard.stipop.io/
        /// you can get api key from here https://prnt.sc/26ofmq9
        /// </summary>
        public static string StickersApikey = "0a441b19287cad752e87f6072bb914c0";//#New
         
        //*********************************************************

        /// <summary>
        ///  Currency
        /// CurrencyStatic = true : get currency from app not api 
        /// CurrencyStatic = false : get currency from api (default)
        /// </summary>
        public static readonly bool CurrencyStatic = false;
        public static readonly string CurrencyIconStatic = "$";
        public static readonly string CurrencyCodeStatic = "USD";
        public static readonly string CurrencyFundingPriceStatic = "$";

        //Profile settings
        //*********************************************************
        public static bool ShowGift = true;
        public static bool ShowWallet = true; 
        public static bool ShowGoPro = true;  
        public static bool ShowAddToFamily = true;

        public static bool ShowUserGroup = false; 
        public static bool ShowUserPage = false;  
        public static bool ShowUserImage = true;  
        public static bool ShowUserSocialLinks = false; 

        public static CoverImageStyle CoverImageStyle = CoverImageStyle.CenterCrop; 

        /// <summary>
        /// The default value comes from the site .. in case it is not available, it is taken from these values
        /// </summary>
        public static string WeeklyPrice = "3"; 
        public static string MonthlyPrice = "8"; 
        public static string YearlyPrice = "89"; 
        public static string LifetimePrice = "259";

        //Native Post settings
        //********************************************************* 
        public static bool ShowTextWithSpace = true; 

        public static bool ShowTextShareButton = false;
        public static bool ShowShareButton = true;
         
        public static int AvatarPostSize = 60;
        public static int ImagePostSize = 200;
        public static string PostApiLimitOnScroll = "22";

        //Get post in background >> 1 Min = 30 Sec
        public static long RefreshPostSeconds = 30000;  
        public static string PostApiLimitOnBackground = "12"; 

        public static bool AutoPlayVideo = true;
         
        public static bool EmbedPlayTubePostType = true;
        public static bool EmbedDeepSoundPostType = true;
        public static VideoPostTypeSystem EmbedFacebookVideoPostType = VideoPostTypeSystem.EmbedVideo; 
        public static VideoPostTypeSystem EmbedVimeoVideoPostType = VideoPostTypeSystem.EmbedVideo; 
        public static VideoPostTypeSystem EmbedPlayTubeVideoPostType = VideoPostTypeSystem.Link; 
        public static VideoPostTypeSystem EmbedTikTokVideoPostType = VideoPostTypeSystem.Link; 
        public static VideoPostTypeSystem EmbedTwitterPostType = VideoPostTypeSystem.Link; 
        public static bool ShowSearchForPosts = true; 
        public static bool EmbedLivePostType = true;
         
        //new posts users have to scroll back to top
        public static bool ShowNewPostOnNewsFeed = true; 
        public static bool ShowAddPostOnNewsFeed = false; 
        public static bool ShowCountSharePost = true;

        public static WRecyclerView.VolumeState DefaultVolumeVideoPost = WRecyclerView.VolumeState.On; 

        /// <summary>
        /// Post Privacy
        /// ShowPostPrivacyForAllUser = true : all posts user have icon Privacy 
        /// ShowPostPrivacyForAllUser = false : just my posts have icon Privacy (default)
        /// </summary>
        public static bool ShowPostPrivacyForAllUser = false; 

        public static bool ShowFullScreenVideoPost = true;

        public static bool EnableVideoCompress = false;
        public static bool EnableFitchOgLink = true; //#New

        //Trending page
        //*********************************************************   
        public static bool ShowTrendingPage = true;
         
        public static bool ShowProUsersMembers = true;
        public static bool ShowPromotedPages = true;
        public static bool ShowTrendingHashTags = true;
        public static bool ShowLastActivities = true;
        public static bool ShowShortcuts = true; 
        public static bool ShowFriendsBirthday = true; 
        public static bool ShowAnnouncement = true;

        /// <summary>
        /// https://www.weatherapi.com
        /// </summary>
        public static WeatherType WeatherType = WeatherType.Celsius; //#New
        public static bool ShowWeather = true;  
        public static string KeyWeatherApi = "e7cffc4d6a9a4a149a1113143201711";

        /// <summary>
        /// https://openexchangerates.org
        /// #Currency >> Your currency
        /// #Currencies >> you can use just 3 from those : USD,EUR,DKK,GBP,SEK,NOK,CAD,JPY,TRY,EGP,SAR,JOD,KWD,IQD,BHD,DZD,LYD,AED,QAR,LBP,OMR,AFN,ALL,ARS,AMD,AUD,BYN,BRL,BGN,CLP,CNY,MYR,MAD,ILS,TND,YER
        /// </summary>
        public static bool ShowExchangeCurrency = false; 
        public static string KeyCurrencyApi = "644761ef2ba94ea5aa84767109d6cf7b"; 
        public static string ExCurrency = "USD";  
        public static string ExCurrencies = "EUR,GBP,TRY"; 
        public static readonly List<string> ExCurrenciesIcons = new List<string>() {"€", "£", "₺"};

        //********************************************************* 

        /// <summary>
        /// you can edit video using FFMPEG 
        /// </summary>
        public static bool EnableVideoEditor = true; //#New


        public static bool ShowUserPoint = true;

        //Add Post
        public static AddPostSystem AddPostSystem = AddPostSystem.AllUsers;

        public static bool ShowGalleryImage = true;
        public static bool ShowGalleryVideo = true;
        public static bool ShowMention = true;
        public static bool ShowLocation = true;
        public static bool ShowFeelingActivity = true;
        public static bool ShowFeeling = true;
        public static bool ShowListening = true;
        public static bool ShowPlaying = true;
        public static bool ShowWatching = true;
        public static bool ShowTraveling = true;
        public static bool ShowGif = true;
        public static bool ShowFile = true;
        public static bool ShowMusic = true;
        public static bool ShowPolls = true;
        public static bool ShowColor = true;
        public static bool ShowVoiceRecord = true; 

        public static bool ShowAnonymousPrivacyPost = true;

        //Advertising 
        public static bool ShowAdvertisingPost = true;  

        //Settings Page >> General Account
        public static bool ShowSettingsGeneralAccount = true;
        public static bool ShowSettingsAccount = true;
        public static bool ShowSettingsSocialLinks = true;
        public static bool ShowSettingsPassword = true;
        public static bool ShowSettingsBlockedUsers = true;
        public static bool ShowSettingsDeleteAccount = true;
        public static bool ShowSettingsTwoFactor = true; 
        public static bool ShowSettingsManageSessions = true;  
        public static bool ShowSettingsVerification = true;
         
        public static bool ShowSettingsSocialLinksFacebook = true; 
        public static bool ShowSettingsSocialLinksTwitter = true; 
        public static bool ShowSettingsSocialLinksGoogle = true; 
        public static bool ShowSettingsSocialLinksVkontakte = true;  
        public static bool ShowSettingsSocialLinksLinkedin = true;  
        public static bool ShowSettingsSocialLinksInstagram = true;  
        public static bool ShowSettingsSocialLinksYouTube = true;  

        //Settings Page >> Privacy
        public static bool ShowSettingsPrivacy = true;
        public static bool ShowSettingsNotification = true;

        //Settings Page >> Tell a Friends (Earnings)
        public static bool ShowSettingsInviteFriends = true;

        public static bool ShowSettingsShare = true;
        public static bool ShowSettingsMyAffiliates = true;
        public static bool ShowWithdrawals = true;

        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// Just replace it with this 5 lines of code
        /// <uses-permission android:name="android.permission.READ_CONTACTS" />
        /// <uses-permission android:name="android.permission.READ_PHONE_NUMBERS" />
        /// </summary>
        public static bool InvitationSystem = true; 

        //Settings Page >> Help && Support
        public static bool ShowSettingsHelpSupport = true;

        public static bool ShowSettingsHelp = true;
        public static bool ShowSettingsReportProblem = true;
        public static bool ShowSettingsAbout = true;
        public static bool ShowSettingsPrivacyPolicy = true;
        public static bool ShowSettingsTermsOfUse = true;

        public static bool ShowSettingsRateApp = true; 
        public static int ShowRateAppCount = 5; 
         
        public static bool ShowSettingsUpdateManagerApp = false; 

        public static bool ShowSettingsInvitationLinks = true; 
        public static bool ShowSettingsMyInformation = true; 

        public static bool ShowSuggestedUsersOnRegister = true;

        //Set Theme Tab
        //*********************************************************
        public static bool SetTabDarkTheme = false;
        public static MoreTheme MoreTheme = MoreTheme.Card; 

        //Bypass Web Errors  
        //*********************************************************
        public static bool TurnTrustFailureOnWebException = true;
        public static bool TurnSecurityProtocolType3072On = true;

        //*********************************************************
        public static bool RenderPriorityFastPostLoad = false;

        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// <uses-permission android:name="com.android.vending.BILLING" />
        /// </summary>
        public static bool ShowInAppBilling = false;

        /// <summary>
        /// Paypal and google pay using Braintree Gateway https://www.braintreepayments.com/
        /// 
        /// Add info keys in Payment Methods : https://prnt.sc/1z5bffc & https://prnt.sc/1z5b0yj
        /// To find your merchant ID :  https://prnt.sc/1z59dy8
        ///
        /// Tokenization Keys : https://prnt.sc/1z59smv
        /// </summary>
        public static bool ShowPaypal = true;
        public static string MerchantAccountId = "test"; //#New

        public static string SandboxTokenizationKey = "sandbox_kt2f6mdh_hf4c******"; //#New
        public static string ProductionTokenizationKey = "production_t2wns2y2_dfy45******"; //#New

        public static bool ShowBankTransfer = true; 
        public static bool ShowCreditCard = true;

        //********************************************************* 
        public static bool ShowCashFree = true;  

        /// <summary>
        /// Currencies : http://prntscr.com/u600ok
        /// </summary>
        public static string CashFreeCurrency = "INR";  

        //********************************************************* 

        /// <summary>
        /// If you want RazorPay you should change id key in the analytic.xml file
        /// razorpay_api_Key >> .. line 24 
        /// </summary>
        public static bool ShowRazorPay = true; 

        /// <summary>
        /// Currencies : https://razorpay.com/accept-international-payments
        /// </summary>
        public static string RazorPayCurrency = "USD";  
         
        public static bool ShowPayStack = true;  
        public static bool ShowPaySera = false;  //#Next Version   
                                               
        //********************************************************* 

    }
}