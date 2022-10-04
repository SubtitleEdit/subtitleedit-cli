# syntax=docker/dockerfile:1

FROM bitnami/dotnet-sdk:6

#Get the se cli code from github
WORKDIR /workdir/subtitleedit-cli/src
COPY ./src /workdir/subtitleedit-cli/src

#Compile and publish
WORKDIR /workdir/subtitleedit-cli/src/se-cli
RUN dotnet publish -c release -r ubuntu.22.04-x64 --self-contained seconv.csproj


FROM ubuntu:22.04
LABEL maintainer="Wauter De Bruyne"

WORKDIR /secli/
COPY --from=0 /workdir/subtitleedit-cli/src/se-cli/bin/release/net6.0/ubuntu.22.04-x64/publish /secli

# patch the runtime config, make executable
COPY ./docker/seconv.runtimeconfig.json /secli/
RUN chmod +x /secli/seconv

# copy entry point script, make executable
COPY ./docker/entrypoint.sh /
RUN chmod +x /entrypoint.sh


ENTRYPOINT ["/entrypoint.sh"]
