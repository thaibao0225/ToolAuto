using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolAuto.Management;
using ToolAuto.Model.Socical;
using ToolAuto.Management.Socical;
using ToolAuto.Model.Shop;
using ToolAuto.Management.Shop;

namespace ToolAuto
{
    public partial class Form1 : Form
    {
        //Social
        UserFbModel userFbModel;
        UserInstagramModel UserInstagramModel;
        UserTikTokModel UserTikTokModel;
        UserYoutubeModel UserYoutubeModel;
        UserZaloModel UserZaloModel;
        UserGoogleModel UserGoogleModel;

        //Shop
        UserChoTotModel UserChoTotModel;
        UserLazadaModel UserLazadaModel;
        UserMarketingPlaceFbModel UserMarketingPlaceFbModel;
        UserSendoModel UserSendoModel;
        UserShopeeModel UserShopeeModel;



        public Form1()
        {
            InitializeComponent();
        }

        //Social #########################################################################################################################
        private void SetDataInputSocialFacebook()
        {
            userFbModel = new UserFbModel();
            userFbModel.user = FacebookUserTxt.Text;
            userFbModel.password = FacebookPasswordTxt.Text;
            userFbModel.UserName = FacebookUserNameTxt.Text;
        }

        private void SetDataInputSocialInstagram()
        {
            UserInstagramModel = new UserInstagramModel();
            UserInstagramModel.user = InstagramUserTxt.Text;
            UserInstagramModel.password = InstagramPasswordTxt.Text;
            UserInstagramModel.UserName = InstagramUserNameTxt.Text;
        }

        private void SetDataInputSocialTikTok()
        {
            UserTikTokModel = new UserTikTokModel();
            UserTikTokModel.user = TikTokUserTxt.Text;
            UserTikTokModel.password = TikTokPasswordTxt.Text;
            UserTikTokModel.UserName = TikTokUserNameTxt.Text;
        }

        private void SetDataInputSocialYoutube()
        {
            UserYoutubeModel = new UserYoutubeModel();
            UserYoutubeModel.user = YoutubeUserTxt.Text;
            UserYoutubeModel.password = YoutubePasswordTxt.Text;
            UserYoutubeModel.UserName = YoutubeUserNameTxt.Text;
        }

        private void SetDataInputSocialZalo()
        {
            UserZaloModel = new UserZaloModel();
            UserZaloModel.user = ZaloUserTxt.Text;
            UserZaloModel.password = ZaloPasswordTxt.Text;
            UserZaloModel.UserName = ZaloUserNameTxt.Text;
        }

        //Shop #########################################################################################################################
        private void SetDataInputSocialShopee()
        {
            UserShopeeModel = new UserShopeeModel();
            UserShopeeModel.user = ShopeeUserTxt.Text;
            UserShopeeModel.password = ShopeePasswordTxt.Text;
            UserShopeeModel.UserName = ShopeeUserNameTxt.Text;
        }

        private void SetDataInputSocialLazada()
        {
            UserLazadaModel = new UserLazadaModel();
            UserLazadaModel.user = LazadaUserTxt.Text;
            UserLazadaModel.password = LazadaPasswordTxt.Text;
            UserLazadaModel.UserName = LazadaUserNameTxt.Text;
        }

        private void SetDataInputSocialSendo()
        {
            UserSendoModel = new UserSendoModel();
            UserSendoModel.user = SendoUserTxt.Text;
            UserSendoModel.password = SendoPasswordTxt.Text;
            UserSendoModel.UserName = SendoUserNameTxt.Text;
        }

        private void SetDataInputSocialChoTot()
        {
            UserChoTotModel = new UserChoTotModel();
            UserChoTotModel.user = ChoTotUserTxt.Text;
            UserChoTotModel.password = ChoTotPasswordTxt.Text;
            UserChoTotModel.UserName = ChoTotUserNameTxt.Text;
        }

        private void SetDataInputSocialMarketPlaceFB()
        {
            UserMarketingPlaceFbModel = new UserMarketingPlaceFbModel();
            UserMarketingPlaceFbModel.user = MarketPlaceFBUserTxt.Text;
            UserMarketingPlaceFbModel.password = MarketPlaceFBPasswordTxt.Text;
            UserMarketingPlaceFbModel.UserName = MarketPlaceFBUserNameTxt.Text;
        }

        private void SetDataInputSocialGoogle()
        {
            UserGoogleModel = new UserGoogleModel();
            UserGoogleModel.user = GoogleUserTxt.Text;
            UserGoogleModel.password = GooglePasswordTxt.Text;
            UserGoogleModel.UserName = GoogleUserNameTxt.Text;
        }




        private void GetData()
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OtherManagement otherManagement = new OtherManagement();

            otherManagement.test();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Start Facebook
        private void button2_Click(object sender, EventArgs e)
        {
            SetDataInputSocialFacebook();

            FacebookManagement facebookManagement = new FacebookManagement(userFbModel);
            facebookManagement.StartProfile();

        }


        //Start Zalo
        private void button3_Click(object sender, EventArgs e)
        {
            SetDataInputSocialZalo();

            ZaloManagement zaloManagement = new ZaloManagement(UserZaloModel);
            zaloManagement.StartProfile();

        }

        //Start Instagram
        private void button4_Click(object sender, EventArgs e)
        {
            SetDataInputSocialInstagram();

            InstagramManagement instagramManagement = new InstagramManagement(UserInstagramModel);
            instagramManagement.StartProfile();
        }

        //Start TikTok
        private void button5_Click(object sender, EventArgs e)
        {
            SetDataInputSocialTikTok();

            TikTokManagement tikTokManagement = new TikTokManagement(UserTikTokModel);
            tikTokManagement.StartProfile();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        //Start Youtube
        private void button6_Click(object sender, EventArgs e)
        {
            SetDataInputSocialYoutube();

            YoutubeManagement youtubeManagement = new YoutubeManagement(UserYoutubeModel);
            youtubeManagement.StartProfile();

        }

        //Start Shopee
        private void button7_Click(object sender, EventArgs e)
        {
            SetDataInputSocialShopee();

            ShopeeManagement shopeeManagement = new ShopeeManagement(UserShopeeModel);
            shopeeManagement.StartProfile();
        }

        //Start Lazada
        private void button8_Click(object sender, EventArgs e)
        {
            SetDataInputSocialLazada();

            LazadaManagement lazadaManagement = new LazadaManagement(UserLazadaModel);
            lazadaManagement.StartProfile();
        }

        //Start Sendo
        private void button9_Click(object sender, EventArgs e)
        {
            SetDataInputSocialSendo();

            SendoManagement sendoManagement = new SendoManagement(UserSendoModel);
            sendoManagement.StartProfile();
        }

        //Start ChoTot
        private void button10_Click(object sender, EventArgs e)
        {
            SetDataInputSocialChoTot();

            ChototManagement chototManagement = new ChototManagement(UserChoTotModel);
            chototManagement.StartProfile();
        }

        //Start MarketPlace
        private void button11_Click(object sender, EventArgs e)
        {
            SetDataInputSocialMarketPlaceFB();

            MarketPlaceManagement marketPlaceManagement = new MarketPlaceManagement(UserMarketingPlaceFbModel);
            marketPlaceManagement.StartProfile();
        }

        //Start Google
        private void button12_Click(object sender, EventArgs e)
        {
            SetDataInputSocialGoogle();

            GoogleManagement googleManagement = new GoogleManagement(UserGoogleModel);
            googleManagement.StartProfile();
        }
    }
}
