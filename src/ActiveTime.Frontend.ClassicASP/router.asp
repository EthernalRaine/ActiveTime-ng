<!-- #Include File="master.asp" -->
<%
	set req = Request.ServerVariables("QUERY_STRING")
	if instr(req, "/home")>0 then
        %><!-- #Include File="views/home.asp" --><%
	end if
%>