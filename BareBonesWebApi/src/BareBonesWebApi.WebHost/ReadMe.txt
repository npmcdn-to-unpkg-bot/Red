1. Remove all references
2. Add reference to BareBonesWebApi.WebApi
3. Install package Microsoft.Owin.Host.SystemWeb
	This installs
		Microsoft.Owin
		Microsoft.Owin.Host.SystemWeb
		Owin
4. Configure app to not open a page
5. Configure app to run in IIS
6. Add the following to web.config
	<runtime>
		<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
			<dependentAssembly>
			<assemblyIdentity name="Microsoft.Owin" publicKeyToken="31bf3856ad364e35" culture="neutral" />
			<bindingRedirect oldVersion="0.0.0.0-999.999.999.999" newVersion="3.0.1.0" />
			</dependentAssembly>
		</assemblyBinding>
	</runtime>

