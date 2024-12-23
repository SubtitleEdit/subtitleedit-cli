# syntax=docker/dockerfile:1

FROM bitnami/dotnet-sdk:8

#Get the se cli code from github
WORKDIR /workdir/subtitleedit-cli/src
COPY ./src /workdir/subtitleedit-cli/src

#Compile and publish
WORKDIR /workdir/subtitleedit-cli/src/se-cli
RUN dotnet publish -c release -r ubuntu.25.04-x64 --self-contained seconv.csproj


FROM ubuntu:25.04
LABEL maintainer="Wauter De Bruyne"

COPY --from=0 /workdir/subtitleedit-cli/src/se-cli/bin/release/net6.0/ubuntu.25.04-x64/publish /secli

# patch the runtime config, make executable

RUN chmod +x /secli/seconv

# will expect subtitles here by default
WORKDIR /subtitles/

ENTRYPOINT ["/secli/seconv"]
