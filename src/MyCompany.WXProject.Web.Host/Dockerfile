FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/MyCompany.WXProject.Web.Host/MyCompany.WXProject.Web.Host.csproj", "src/MyCompany.WXProject.Web.Host/"]
COPY ["src/MyCompany.WXProject.Web.Core/MyCompany.WXProject.Web.Core.csproj", "src/MyCompany.WXProject.Web.Core/"]
COPY ["src/MyCompany.WXProject.EntityFrameworkCore/MyCompany.WXProject.EntityFrameworkCore.csproj", "src/MyCompany.WXProject.EntityFrameworkCore/"]
COPY ["src/MyCompany.WXProject.Core/MyCompany.WXProject.Core.csproj", "src/MyCompany.WXProject.Core/"]
COPY ["src/MyCompany.WXProject.Application/MyCompany.WXProject.Application.csproj", "src/MyCompany.WXProject.Application/"]
RUN dotnet restore "src/MyCompany.WXProject.Web.Host/MyCompany.WXProject.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/MyCompany.WXProject.Web.Host"
RUN dotnet build "MyCompany.WXProject.Web.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MyCompany.WXProject.Web.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyCompany.WXProject.Web.Host.dll"]
