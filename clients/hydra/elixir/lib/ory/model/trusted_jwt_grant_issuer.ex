# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.TrustedJwtGrantIssuer do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :"created_at",
    :"expires_at",
    :"id",
    :"issuer",
    :"public_key",
    :"scope",
    :"subject"
  ]

  @type t :: %__MODULE__{
    :"created_at" => DateTime.t | nil,
    :"expires_at" => DateTime.t | nil,
    :"id" => String.t | nil,
    :"issuer" => String.t | nil,
    :"public_key" => Ory.Model.TrustedJsonWebKey.t | nil,
    :"scope" => [String.t] | nil,
    :"subject" => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.TrustedJwtGrantIssuer do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:"public_key", :struct, Ory.Model.TrustedJsonWebKey, options)
  end
end
