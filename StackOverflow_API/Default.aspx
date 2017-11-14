<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StackOverflow_API._Default" %>

<%@ Import Namespace="StackOverflow_API.Models" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kiosk IT System Trading LLC</title>
    <link href="Designs/Css/bootstrap.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <br />
        <div class="alert alert-info">
            <h4 style="text-align: center">
                Stack Overflow Quesions API- Kiosk IT System Trading LLC
            </h4>
        </div>
        <br />
        <asp:Button ID="btnRefresh" CssClass="btn btn-sm btn-default" runat="server" Text="Refresh"
            OnClick="btnRefresh_Click" />
        <asp:Label ID="lblMessages" CssClass="pull-right" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <div style="height:750px;overflow:scroll">
        <asp:GridView ID="GvQuestions" runat="server" AutoGenerateColumns="false" CssClass="table table-responsive-sm table-light">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <div style="text-align: center; width: 100px">
                            <asp:Label ID="lblDisplayName" runat="server" Text='<%# ((Questions)Container.DataItem).Owner.DisplayName %>'> </asp:Label><br />

                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# ((Questions)Container.DataItem).Owner.ProfileImage %>'
                                Height="50px" Width="50px" CssClass="img-thumbnail" />
                        </div>
                    </ItemTemplate>
                    <HeaderTemplate>
                        UserName
                    </HeaderTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <div>
                            <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("Title") %>' NavigateUrl='<%# Eval("Link") %>'
                                onclick="javascript:w= window.open(this.href,'Download Image','left=20,top=20,width=500,height=500,toolbar=0,resizable=0');return false;"></asp:HyperLink>
                            <br />
                            <asp:Label ID="lblCreationDate" CssClass="left" runat="server" Text='<%# Questions.UnixTimeStampToDateTime(Convert.ToDouble(Eval("CreationDate"))).ToString() %>'> </asp:Label>
                        </div>
                    </ItemTemplate>
                    <HeaderTemplate>
                        Questions
                    </HeaderTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ViewCount" HeaderText="No.Of view" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblCreationDt" runat="server" Text='<%# Eval("AnswerCount") %>'> </asp:Label>
                    </ItemTemplate>
                    <HeaderTemplate>
                        Answer Count
                    </HeaderTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
   </div>
    </div>
    </form>
</body>
</html>
