# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: GlobalDefinition/GlobalRates.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\"GlobalDefinition/GlobalRates.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xc0\x02\n\x0bGlobalRates\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x33\n\x04pkey\x18\x02 \x01(\x0b\x32%.spiderrock.protobuf.GlobalRates.PKey\x12-\n\ttimestamp\x18\x64 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x35\n\x05\x63urve\x18g \x03(\x0b\x32&.spiderrock.protobuf.GlobalRates.Curve\x1a<\n\x04PKey\x12\x34\n\x0brate_source\x18\n \x01(\x0e\x32\x1f.spiderrock.protobuf.RateSource\x1a#\n\x05\x43urve\x12\x0c\n\x04\x64\x61ys\x18j \x01(\x05\x12\x0c\n\x04rate\x18m \x01(\x02\x62\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'GlobalDefinition.GlobalRates_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_GLOBALRATES']._serialized_start=118
  _globals['_GLOBALRATES']._serialized_end=438
  _globals['_GLOBALRATES_PKEY']._serialized_start=341
  _globals['_GLOBALRATES_PKEY']._serialized_end=401
  _globals['_GLOBALRATES_CURVE']._serialized_start=403
  _globals['_GLOBALRATES_CURVE']._serialized_end=438
# @@protoc_insertion_point(module_scope)
