cmake_minimum_required(VERSION 3.16)
project(CustomEngine)

set(CMAKE_RUNTIME_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/$<CONFIGURATION>")
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/$<CONFIGURATION>")

add_subdirectory(vendor/SDL EXCLUDE_FROM_ALL)

add_executable(CustomEngine WIN32 src/test.c)

target_link_libraries(CustomEngine PRIVATE SDL3::SDL3)