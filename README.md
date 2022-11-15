# Subtitle Edit cli 

.NET 6 console subtitle converter for Windows, Linux, and Mac.

Code is based on SE 3.6.9.

Imaged based formats/OCR was removed.

To update, the `SubtitleFormats` should be copied from latest SE.

How to compile: `dotnet build seconv.csproj`

How to run: `./seconv <pattern> <name-of-format-without-spaces> [<optional-parameters>]`.

E.g.: `./seconv *.sub subrip` - for more info see https://www.nikse.dk/subtitleedit/help#commandline

This was made due to https://github.com/SubtitleEdit/subtitleedit/issues/3568


## Build and run with docker

### Build

Be in the root directory of the repository, then run:    
```
docker build -t seconv:1.0 -f docker/Dockerfile .
```

This is a multi stage build, it first builds the application, then creates the docker container for execution. 

### Run

Example:

Navigate to the 'docker' folder, then execute:   
```
docker run --rm -it -v $(pwd)/subtitles:/subtitles seconv:1.0  sample.srt pac
```

