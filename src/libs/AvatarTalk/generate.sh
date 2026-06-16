install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace AvatarTalk \
  --clientClassName AvatarTalkClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations

rm -rf ../../cli/AvatarTalk.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/AvatarTalk.CLI \
  --sdk-project ../../libs/AvatarTalk/AvatarTalk.csproj \
  --targetFramework net10.0 \
  --namespace AvatarTalk \
  --clientClassName AvatarTalkClient \
  --package-id AvatarTalk.CLI \
  --tool-command-name avatar-talk \
  --user-secrets-id AvatarTalk.CLI \
  --api-key-env-var AVATARTALK_API_KEY \
  --base-url-env-var AVATARTALK_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
