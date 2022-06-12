FROM mcr.microsoft.com/dotnet/sdk:6.0
RUN dotnet tool install -g dotnet-ef
ENV PATH $PATH:/root/.dotnet/tools

COPY . /app
WORKDIR /app

CMD exec /bin/bash -c "trap : TERM INT; sleep infinity & wait"