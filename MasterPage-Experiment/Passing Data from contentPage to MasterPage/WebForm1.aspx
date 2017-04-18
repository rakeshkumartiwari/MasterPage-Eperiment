<%@ Page Title="" Language="C#" MasterPageFile="~/Passing Data from contentPage to MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPage_Experiment.WebForm1" %>
<%@MasterType VirtualPath="~/Passing Data from contentPage to MasterPage/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Please enter some text.</h3>
    <asp:TextBox ID="txtChildPage" runat="server"></asp:TextBox>
    <asp:Button ID="btnChild" runat="server" Text="Set text" OnClick="btnChild_Click" />
</asp:Content>
