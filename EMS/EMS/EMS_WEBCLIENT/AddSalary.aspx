﻿<%@ Page Title="Add Doctor page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSalary.aspx.cs" Inherits="HospitalWebClient.AddSalary" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
    media="screen" />

    <form id="form1" align ="center">
        <div style="max-width: 600px;">
            <h2 class="form-signin-heading">
                Add/Update Salary</h2>
            <label for="id">
                Employee ID</label>
            <asp:TextBox ID="id" runat="server" CssClass="form-control" placeholder="Enter Employee ID"
                required />
            <br />

            <label for="salary">
                Employee Salary</label>
            <asp:TextBox ID="salary" runat="server" CssClass="form-control" placeholder="Enter Salary"
                required />
            <br />
            
            <br />
            <asp:Button ID="btnadd" Text="Add Salary" runat="server" Class="btn btn-primary" OnClick="btnadd_Click"/>
            &nbsp;  &nbsp;
            <asp:Button ID="btnupdate" Text="Update Salary" runat="server" Class="btn btn-primary" OnClick="btnupdate_Click"/>
            <br />
            <br />
            <asp:Label ID="errmsg" runat="server" />
            </div>
            <br />
            
        </div>
    </form>

</asp:Content>

