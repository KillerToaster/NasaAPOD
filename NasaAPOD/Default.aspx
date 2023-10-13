<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NasaAPOD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">NASA Astronomy Picture of the Day</h1>
            <p class="lead">A serivce for getting the astronomy picture of the day.</p>
            <p class="lead">&nbsp;</p>
            <p class="lead">&nbsp;</p>
            <p class="lead">
                <asp:Image ID="currentPic" runat="server" Height="784px" Width="1053px" ImageUrl="https://apod.nasa.gov/apod/image/2309/HarvestMoonNest.jpg" />
            </p>
            <p class="lead">
                <asp:TextBox ID="explanationTB" runat="server" Height="333px" TextMode="MultiLine" Width="1033px">Explanation: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras lectus est, aliquet eget enim sit amet, blandit faucibus mi. Nam maximus a felis nec suscipit. Ut hendrerit, nibh vel vehicula semper, arcu turpis iaculis ante, ac convallis massa risus ac tellus. Etiam sagittis dictum tortor, vel eleifend mi ultrices ut. Quisque eget turpis quis enim tempor vehicula in luctus enim. Quisque tristique, sapien sit amet tempus fermentum, nisi diam pulvinar nisl, sit amet ornare enim neque sed diam. Donec rutrum aliquet erat, non aliquam justo. Donec sed accumsan mauris. </asp:TextBox>
            </p>
            <p class="lead">Want to see the picture from a previous day? Enter a past date below:</p>
            <p class="lead">Year:
                <asp:TextBox ID="yearTB" runat="server"  ValidateRequestMode="Enabled" Width="74px">YYYY</asp:TextBox>
&nbsp;Month:
                <asp:TextBox ID="monthTB" runat="server">MM</asp:TextBox>
&nbsp;Day:
                <asp:TextBox ID="dayTB" runat="server">DD</asp:TextBox>
            </p>
            <p class="lead">
                <asp:Button ID="getOldPicBtn" runat="server" Text="Get Picture!" Width="699px" OnClick="getOldPicBtn_Click" />
            </p>
            <p class="lead">&nbsp;</p>
            <p class="lead"></p>
            <p class="lead">
                
                
            </p>
            <p class="lead">
                
                
            </p>
            <p class="lead">
                
            </p>
        </section>
    </main>

</asp:Content>
