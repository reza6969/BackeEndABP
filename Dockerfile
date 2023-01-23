FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/LOopOop.Web.Host/LOopOop.Web.Host.csproj", "src/LOopOop.Web.Host/"]
COPY ["src/LOopOop.Web.Core/LOopOop.Web.Core.csproj", "src/LOopOop.Web.Core/"]
COPY ["src/LOopOop.Application/LOopOop.Application.csproj", "src/LOopOop.Application/"]
COPY ["src/LOopOop.Core/LOopOop.Core.csproj", "src/LOopOop.Core/"]
COPY ["src/LOopOop.EntityFrameworkCore/LOopOop.EntityFrameworkCore.csproj", "src/LOopOop.EntityFrameworkCore/"]
WORKDIR "/src/src/LOopOop.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/LOopOop.Web.Host", "src/LOopOop.Web.Host"]
COPY ["src/LOopOop.Web.Core", "src/LOopOop.Web.Core"]
COPY ["src/LOopOop.Application", "src/LOopOop.Application"]
COPY ["src/LOopOop.Core", "src/LOopOop.Core"]
COPY ["src/LOopOop.EntityFrameworkCore", "src/LOopOop.EntityFrameworkCore"]
WORKDIR "/src/src/LOopOop.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "LOopOop.Web.Host.dll"]
