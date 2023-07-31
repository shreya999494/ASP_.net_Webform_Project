<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApplication1.test" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center">
        <div>
            <asp:Label ID="Label1" runat="server" Text="FirstName">FirstName: </asp:Label>
            <asp:TextBox ID="txt_firstName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="LastName">LastName: </asp:Label>
            <asp:TextBox ID="txt_lastName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Email">Email: </asp:Label>
            <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Gender">Gender: </asp:Label>
            <asp:RadioButton ID="rdb_male" Text="Male" GroupName ="Gender" runat="server" />
            <asp:RadioButton ID="rdb_female" Text="Female" GroupName ="Gender" runat="server" />
            <asp:RadioButton ID="rdb_other" Text="Other" GroupName ="Gender" runat="server" />
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Country">Country: </asp:Label>
            <asp:DropDownList ID="ddl_country"  runat="server" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="ContactNo">Contact No.: </asp:Label>
            <asp:TextBox ID="txt_contactNo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label7" runat="server" Text="Salary">Salary: </asp:Label>
            <asp:TextBox ID="txt_salary" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click"/>
        </div>
    </div>
    
</asp:Content>
