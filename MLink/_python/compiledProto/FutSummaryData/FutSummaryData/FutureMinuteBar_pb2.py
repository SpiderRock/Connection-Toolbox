# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: FutSummaryData/FutureMinuteBar.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n$FutSummaryData/FutureMinuteBar.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xf9\x04\n\x0f\x46utureMinuteBar\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x37\n\x04pkey\x18\x02 \x01(\x0b\x32).spiderrock.protobuf.FutureMinuteBar.PKey\x12\x0c\n\x04\x64\x61te\x18\x64 \x01(\t\x12\x0c\n\x04time\x18g \x01(\t\x12\x10\n\x08prt_open\x18j \x01(\x01\x12\x10\n\x08prt_high\x18m \x01(\x01\x12\x0f\n\x07prt_low\x18p \x01(\x01\x12\x10\n\x08prt_last\x18s \x01(\x01\x12\x10\n\x08prt_vWap\x18v \x01(\x01\x12\x12\n\nprt_volume\x18y \x01(\x05\x12\x11\n\tprt_count\x18| \x01(\x05\x12\x12\n\nqte_hi_bid\x18\x7f \x01(\x01\x12\x13\n\nqte_lo_ask\x18\x82\x01 \x01(\x01\x12\x11\n\x08qte_twap\x18\x85\x01 \x01(\x01\x12\x12\n\tqte_count\x18\x88\x01 \x01(\x05\x12\x0c\n\x03\x62id\x18\x8b\x01 \x01(\x01\x12\x0c\n\x03\x61sk\x18\x8e\x01 \x01(\x01\x12\x0f\n\x06\x62id_sz\x18\x91\x01 \x01(\x05\x12\x0f\n\x06\x61sk_sz\x18\x94\x01 \x01(\x05\x12\x0e\n\x05width\x18\x97\x01 \x01(\x02\x12+\n\x06is_eOB\x18\x9a\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12+\n\x06is_eOH\x18\x9d\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12.\n\ttimestamp\x18\xa0\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x34\n\x04PKey\x12,\n\x04\x66key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKeyb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'FutSummaryData.FutureMinuteBar_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_FUTUREMINUTEBAR']._serialized_start=120
  _globals['_FUTUREMINUTEBAR']._serialized_end=753
  _globals['_FUTUREMINUTEBAR_PKEY']._serialized_start=701
  _globals['_FUTUREMINUTEBAR_PKEY']._serialized_end=753
# @@protoc_insertion_point(module_scope)
