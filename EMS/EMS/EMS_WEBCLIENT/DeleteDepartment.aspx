<%@ Page Title="Delete Doctor page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteDepartment.aspx.cs" Inherits="HospitalWebClient.DeleteDepartment" EnableEventValidation ="false" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
    media="screen" />

    <form id="form1" align ="center">
        <div style="max-width: 400px;">
            <h2 class="form-signin-heading">
                Delete Department</h2>
            <label for="depid">
                Enter ID </label>
            <asp:TextBox ID="depid" runat="server" CssClass="form-control" placeholder="Enter Department ID"
                required />
            <br />
            <asp:Button ID="btndelete" Text="Delete" runat="server" Class="btn btn-danger" OnClick="btndelete_Click" />
            <br />
            <br />
            <asp:Label ID="errdelete" runat="server" />
            </div>
        </div>
    </form>

</asp:Content>
