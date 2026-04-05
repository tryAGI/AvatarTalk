dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace AvatarTalk \
  --clientClassName AvatarTalkClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
