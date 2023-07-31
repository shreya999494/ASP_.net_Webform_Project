<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="grid_emp" AutoGenerateColumns="false" runat="server" >
         <Columns>
            <asp:BoundField HeaderText="Id" DataField="Emp_id" ItemStyle-BackColor="Green" />
            <asp:BoundField HeaderText="FirstName" DataField="FirstName" ControlStyle-BackColor="Red" ControlStyle-Font-Bold="true" />
            <asp:BoundField HeaderText="LastName" DataField="LastName" ControlStyle-BackColor="PowderBlue" ControlStyle-Font-Bold="true" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:TextBox ID="txt_Email" runat="server" Text='<%# Eval("Email") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnk_edit" runat="server" CommandArgument='<%#Eval("Emp_id")%>' OnCommand="lnk_edit_Click">Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnk_delete" runat="server" CommandArgument='<%#Eval("Emp_id")%>' OnCommand="lnk_delete_Click">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
