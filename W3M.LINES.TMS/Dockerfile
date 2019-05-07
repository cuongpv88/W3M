FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["W3M.LINES.TMS/W3M.LINES.TMS.csproj", "W3M.LINES.TMS/"]
RUN dotnet restore "W3M.LINES.TMS/W3M.LINES.TMS.csproj"
COPY . .
WORKDIR "/src/W3M.LINES.TMS"
RUN dotnet build "W3M.LINES.TMS.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "W3M.LINES.TMS.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "W3M.LINES.TMS.dll"]