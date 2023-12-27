// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace MinimalApiSample;

public sealed class InvalidDataException : Exception
{
  public InvalidDataException() { }

  public InvalidDataException(string? message) : base(message) { }

  public InvalidDataException(string? message, Exception? innerException) : base(message, innerException) { }
}
