import { io } from "socket.io-client";

export const socket = io(process.env.NEXT_PUBLIC_DOTNET_WS_URL as string, {
  autoConnect: false,
});
