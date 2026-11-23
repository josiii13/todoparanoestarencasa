
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
 
COPY --from=node:22-slim /usr/local/bin/node /usr/local/bin/node
COPY --from=node:22-slim /usr/local/lib/node_modules /usr/local/lib/node_modules
RUN ln -s /usr/local/lib/node_modules/corepack/dist/corepack.js /usr/local/bin/corepack \
    && corepack enable pnpm
 
COPY sharpness-sharp.csproj ./
RUN dotnet restore
 
COPY . .
RUN pnpm install && node_modules/.bin/tailwindcss -i ./Styles/tailwind.css -o ./wwwroot/app.css --minify
RUN dotnet publish sharpness-sharp.csproj -c Release -o /app/publish --no-restore
 
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
RUN mkdir -p /app/Data
 
ENV PORT=10000 \
    ASPNETCORE_ENVIRONMENT=Production \
    ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
 
EXPOSE 10000
 
ENTRYPOINT ["sh", "-c", "ASPNETCORE_HTTP_PORTS=${PORT} exec dotnet sharpness-sharp.dll"]
 
 