# Subtitle Edit cli 

.NET 8 console subtitle converter for Windows, Linux, and Mac.

Code is based on SE 3.6.9, but should be updated with new subtitle formats from SE.

Imaged based formats/OCR was removed.

To update, the `SubtitleFormats` should be copied from latest SE.

How to compile: `dotnet build seconv.csproj`

How to run: `./seconv <pattern> <name-of-format-without-spaces> [<optional-parameters>]`.

E.g.: `./seconv *.sub subrip` - for more info see https://www.nikse.dk/subtitleedit/help#commandline

This was made due to https://github.com/SubtitleEdit/subtitleedit/issues/3568


## Build and run with Docker

### Prerequisites

#### Install Docker + dotnet 8 SDK

#### Clone repository
```
git clone https://github.com/SubtitleEdit/subtitleedit-cli.git
cd subtitleedit-cli
```

### Build

Reside in the root directory of the repository, then run:    
```
docker build -t seconv:1.0 -f docker/Dockerfile .
```

This is a multi stage build. It first builds the application, then creates the docker image. 

### Run

Run conversion by executing e.g.:   
```
docker run --rm -it -v $(pwd)/subtitles:/subtitles seconv:1.0 sample.srt pac
```

Parameters:
- -v: Mount local subtitles directory.
- sample.srt: input file or pattern. E.g. *.srt.
- pac: output-format. E.g. pac, stl, srt, ass.
