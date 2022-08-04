<%@ Page Title="Profile page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="HospitalWebClient.Profile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
    media="screen" />

    <form id="form1" align ="center">
        <div style="max-width: 400px;">
            <h2 class="form-signin-heading">
                Patient's Details</h2>
            <label for="uname">
                Username</label>
            <asp:TextBox ID="uname" runat="server" CssClass="form-control" placeholder="Enter Username"
                required />
            <br />
            <label for="pass1">
                Password</label>
            <asp:TextBox ID="pass1" runat="server" TextMode="Password" CssClass="form-control"
                placeholder="Enter Password" required />
            <br />
            <label for="pass2">
                Re-Enter Password</label>
            <asp:TextBox ID="pass2" runat="server" TextMode="Password" CssClass="form-control"
                placeholder="Re-Enter Password" required />
            <br />
            <asp:Button ID="btnprupdate" Text="Update" runat="server" Class="btn btn-primary" OnClick="btnprupdate_Click"/>
            <br />
            <br />
            <asp:Label ID="prerr" runat="server" />
            </div>
        </div>
    </form>

</asp:Content>