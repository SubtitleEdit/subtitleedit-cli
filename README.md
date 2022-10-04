# Subtitle Edit cli 

.NET 6 console subtitle converter for Windows, Linux, and Mac.

Code is based on SE 3.6.7
Imaged based formats/OCR was removed.
To update, the `SubtitleFormats` should be copied from latest SE.

How to compile: `dotnet build seconv.csproj`

How to run: `./seconv <pattern> <name-of-format-without-spaces> [<optional-parameters>]`.

E.g.: `./seconv *.sub subrip` - for more info see https://www.nikse.dk/subtitleedit/help#commandline

This was made due to https://github.com/SubtitleEdit/subtitleedit/issues/3568


## Build and run with docker

### Build

Be in the root directory of the repository, then run: `docker build -t se-convert:1.0 -f docker/Dockerfile .`

This is a multi stage build, which will first build and publish the project in a dotnet6 sdk container, then copy the application into a smaller ubuntu container for execution

### Run

Example:

`docker run --rm -it -v $(pwd)/subtitles:/subtitles se-convert:1.0  sample.srt pac`

You need to mount a directory to share and receive subtitles with/from the container. You could use the included 'subtitle' folder. Navigating into the 'docker' folder before executing the above command.

Subtitles to convert should be put inside the 'subtitle' folder, converted subtitles will be created in the 'subtitles/out' folder. You can override this behavior by manually specifying '-inputfolder:/here' and '-outputfolder:/there' parameters, see subtitle edit help for details.