# CLAUDE.md -- AvatarTalk SDK

## Overview

Auto-generated C# SDK for [AvatarTalk](https://avatartalk.ai/) -- a realtime avatar video generation platform with lip-synced TTS, supporting 14 avatars, 3 emotions, and 17 languages.
OpenAPI spec manually created from API documentation (no public OpenAPI spec exists).

## Build & Test

```bash
dotnet build AvatarTalk.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Standard Bearer token via API key:

```csharp
var client = new AvatarTalkClient(apiKey); // AVATARTALK_API_KEY env var
```

## Key Files

- `src/libs/AvatarTalk/openapi.yaml` -- Manually created OpenAPI 3.0.3 spec
- `src/libs/AvatarTalk/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/AvatarTalk/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/AvatarTalk/Extensions/AvatarTalkClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## API Endpoints

```csharp
var client = new AvatarTalkClient(apiKey);

// Video generation
client.GenerateVideoAsync(text, avatar, emotion, language)   // POST /inference
client.GenerateVideoAsync(text, avatar, emotion, stream: GenerateVideoStream.True) // Streaming

// LiveKit sessions
client.CreateLiveKitSessionAsync(avatar, emotion, language)  // POST /livekit/create-session
client.DeleteLiveKitSessionAsync(taskId)                      // DELETE /livekit/delete-session/{taskId}

// Lightning Network payments
client.RequestVideoByTextAsync(text, avatar, emotion)        // POST /lightning/request-video/text
client.RequestVideoByAudioAsync(audio, avatar)               // POST /lightning/request-video/audio
client.GenerateLightningVideoAsync(invoice)                  // POST /lightning/generate-video
client.GetPaymentStatusAsync(invoice)                        // GET /lightning/payment/{invoice}
client.ListPaymentsAsync()                                   // GET /lightning/payments
```

## MEAI AIFunction Tools

| Tool | Description |
|------|-------------|
| `AsGenerateVideoTool()` | Generate a lip-synced avatar video from text |
| `AsCreateLiveKitSessionTool()` | Create a LiveKit session for real-time avatar interaction |
| `AsDeleteLiveKitSessionTool()` | Delete an active LiveKit session |
| `AsGetPaymentStatusTool()` | Check Lightning Network payment status |

## Avatars

14 avatars: `japanese_man`, `old_european_woman`, `european_woman`, `european_man`, `african_man`, `african_woman`, `japanese_woman`, `iranian_man`, `mexican_man`, `mexican_woman`, `colombian_woman`, `old_japanese_man`, `arab_man`, `arab_woman`

## Languages

17 languages: en, es, fr, de, it, pt, pl, tr, ru, nl, cs, ar, zh, ja, hu, ko, hi
