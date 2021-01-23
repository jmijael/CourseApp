<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentView.aspx.cs" Inherits="CoursesApp.Views.StudentView" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Student List</h1>
            <asp:Repeater id="Repeater1" OnItemDataBound="R1_ItemDataBound" runat="server">
              <HeaderTemplate>
              </HeaderTemplate> 
                <ItemTemplate>
                    Id: <asp:Label id ="IdLabel" Text='<%# DataBinder.Eval(Container.DataItem, "Id") %>' Runat="server"/><br />
                    Name: <asp:Label id="NameLabel" Text='<%# DataBinder.Eval(Container.DataItem, "Name") %>' Runat="server"/><br />
                    Course Count: <asp:Label id="CourseCountLabel" Text='<%# DataBinder.Eval(Container.DataItem, "CourseCount") %>' Runat="server"/>
                </ItemTemplate>
              <SeparatorTemplate>
                <hr />
              </SeparatorTemplate>
              <FooterTemplate>
              </FooterTemplate>
             
           </asp:Repeater>
        </div>
</asp:Content>
