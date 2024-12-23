# syntax=docker/dockerfile:1

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /workdir/subtitleedit-cli/src
COPY ./src /workdir/subtitleedit-cli/src

WORKDIR /workdir/subtitleedit-cli/src/se-cli
RUN dotnet publish \
    -c Release \
    -r linux-x64 \
    --self-contained true \
    -p:PublishTrimmed=true \
    -p:PublishSingleFile=true \
    seconv.csproj

FROM ubuntu:24.04
LABEL maintainer="Wauter De Bruyne"

RUN apt-get update && apt-get install -y \
    libicu-dev \
    && rm -rf /var/lib/apt/lists/*

COPY --from=build /workdir/subtitleedit-cli/src/se-cli/bin/Release/net8.0/linux-x64/publish /secli
RUN chmod +x /secli/seconv

WORKDIR /subtitles/
ENTRYPOINT ["/secli/seconv"]